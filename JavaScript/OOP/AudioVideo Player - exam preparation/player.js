function solve () {
    var module = (function() {
        var player,
            playlist,
            playable,
            audio,
            video,
            validator,
            errors,
            CONSTANTS;

        CONSTANTS = {
            STRING_MIN_VALUE : 3,
            STRING_MAX_VALUE : 25,
            IMDB_MIN_RATING : 1,
            IMDB_MAX_RATING : 5,
            MAX_NUMBER: 9007199254740992
        };

        errors = {
            UndefinedValueError: function(name){
                throw new Error(name + ' cannot be undefined');
            },
            NotAnObjectError: function(name){
                throw new Error(name + ' is not an object. Well it should be:)');
            },
            InvalidStringLengthError : function(name){
                throw new Error(name + ' must be between 3 and 25 chars.');
            },
            InvalidStringType: function(name){
                throw new Error(name + ' must be a string value');
            },
            NotPositiveNumberError: function(name){
                throw new Error(name + ' must be a positive number');
            },
            InvalidImdbRating: function(name){
                throw new Error(name + ' must be between ' + CONSTANTS.IMDB_MIN_RATING + 'and ' + CONSTANTS.IMDB_MAX_RATING);
            },
            ElementWithIdNotFound: function(name){
                throw new Error('In ' + name + 'element with the provided ID was not found');
            },
            InvalidPageAndSizeError: function(name){
                throw new Error('Invalid operation: ' + name);
            },
            NotAPlaylistError: function(name){
                throw new Error('The playlist to add must be of type playlist');
            },
            PlaylistNotFoundError: function(){
                throw new Error('Playlist was not found in player');
            }
        };

        validator = {
            
            validateIfUndefined: function(value, name){
                name = name || 'Value';
                if(value === 'undefined'){
                    errors.UndefinedValueError(name);
                }
            },
            validateIfObject: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                if(typeof value !== 'object'){
                    errors.NotAnObjectError(name);
                }
            },
            validateString: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                if(typeof value !== 'string'){
                    errors.InvalidStringType(name);
                }
                if(value.length < CONSTANTS.STRING_MIN_VALUE || 
                    value.length > CONSTANTS.STRING_MAX_VALUE){
                    errors.InvalidStringLengthError(name);
                }
            },
            validateIfNumber: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                if(typeof value !== 'number' || value < 0){
                    errors.NotPositiveNumberError(name);
                }
            },
            validateIMDB: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                this.validateIfNumber(value);
                if(value < CONSTANTS.IMDB_MIN_RATING ||
                    value > CONSTANTS.IMDB_MAX_RATING){
                    errors.InvalidImdbRating(name);
                }
            },
            validateID: function(id){
                this.validateIfUndefined(id);
                if(typeof id !== 'number'){
                    this.validateIfObject(id);
                    id = id.id;//ducktyping
                }
                return id;
            },
            validatePageAndSize: function(page, size, maxElements){
                this.validateIfUndefined(page, 'Page');
                this.validateIfUndefined(size, 'Size');
                this.validateIfNumber(page, 'Page');
                this.validateIfNumber(size, 'Size');

                if(page * size > maxElements){
                    errors.InvalidPageAndSizeError('page * size > maxElements');
                }
                if(page < 0){
                    errors.InvalidPageAndSizeError('page < 0');
                }
                if(size <= 0){
                    errors.InvalidPageAndSizeError('size <= 0');
                }
            },
            validateIfPlaylist: function(playlist){
                if(playlist.type !== 'playlist'){
                    errors.NotAPlaylistError();
                }
            }
        };

        player = (function(){
            var player = Object.create({});

            Object.defineProperty(player, 'init',{
                value: function(name){
                    this.name = name;
                    this._playlists = [];
                    return this;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function(){
                    return this._name;
                },
                set: function(value){
                    validator.validateString(value, 'Player name');
                    this._name = value;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function(playlistToAdd){
                    validator.validateIfPlaylist(playlistToAdd);
                    this._playlists.push(playlistToAdd);

                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function(id){
                    validator.validateIfNumber(id);
                    var foundIndex = findIndexOfElementID(id, this._playlists);
                    if(foundIndex < 0){
                        return null;
                    }
                    return this._playlists[foundIndex];
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function(id){
                    id = validator.validateID(id);
                    var foundIndex = findIndexOfElementID(id, this._playlists);
                    if(foundIndex < 0){
                        errors.ElementWithIdNotFound('removePlaylist');
                    }
                    this._playlists.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists',{
                 value: function(page, size){
                    var maxElements = this._playlists.length - 1;
                    validator.validatePageAndSize(page, size, maxElements);

                    return this._playlists
                        .slice()
                        .sort(sortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            Object.defineProperty(player, 'contains', {
                value: function(playable, playlist){
                    validator.validateIfUndefined(playable, 'Playable in player.contains');
                    validator.validateIfUndefined(playlist, 'Playlist in player.contains');
                    var playableId = validator.validateId(playable.id);
                    var playlistId = validator.validateId(playlist.id);

                    playlist = this.getPlaylistById(playlistId);
                    if (playlist === null) {
                        return false;
                    }

                    playable = playlist.getPlayableById(playableId);
                    if (playable === null) {
                        return false;
                    }

                    return true;
                }
            });

            Object.defineProperty(player, 'search', {
                value: function (pattern) {
                    validator.validateString(pattern, 'Search pattern');

                    return this._playlists
                        .filter(function (playlist) {
                            return playlist
                                .listPlayables()
                                .some(function (playable) {
                                    return playable.length !== undefined && 
                                        playable
                                            .title
                                            .toLowerCase()
                                            .indexOf(pattern.toLowerCase()) >= 0;
                                });
                        })
                        .map(function (playlist) {
                            return {
                                id: playlist.id,
                                name: playlist.name,
                            };
                        });
                }
            });

            return player;
        }());

        playlist = (function(){
            var playlist = Object.create({}),
                currentID = 0;

            Object.defineProperty(playlist, 'init', {
                value: function(name){
                    this.name = name;
                    this._id = currentID += 1;
                    this.type = 'playlist';
                    this._playables = [];

                    return this;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function(){
                    return this._name;
                },
                set: function(value){
                    validator.validateString(value, 'Playlist name');
                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function(playableToAdd){
                    //validate
                    validator.validateIfUndefined(playableToAdd, 'Playable to add to playlist');
                    validator.validateIfObject(playableToAdd, 'Playable to add to playlist');
                    validator.validateIfUndefined(playableToAdd.id, 'Playable to add to playlist');
                    this._playables.push(playableToAdd);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function(id){
                    validator.validateIfNumber(id);
                    var foundIndex = findIndexOfElementID(id, this._playables);
                    if(foundIndex < 0){
                        return null;
                    }
                    return this._playables[foundIndex];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function(id){
                    id = validator.validateID(id);
                    var foundIndex = findIndexOfElementID(id, this._playables);
                    if(foundIndex < 0){
                        errors.ElementWithIdNotFound('removePlayable');
                    }
                    this._playables.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlaylables', {
                value: function(page, size){
                    page = page || 0;
                    size = size || CONSTANTS.MAX_NUMBER;
                    var maxElements = this._playables.length;// or -1?
                    validator.validatePageAndSize(page, size, maxElements);

                    return this._playables
                        .slice()
                        .sort(sortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            return playlist;
        }());


        playable = (function(){
            var playable = Object.create({}),
                currentID = 0;

            Object.defineProperty(playable, 'init', {
                value: function(title, author){
                    this.title = title;
                    this.author = author;
                    this._id = currentID += 1;

                    return this;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function(){
                    return this._title;
                },
                set: function(value){
                    validator.validateString(value, 'Playable title');
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function(){
                    return this._author;
                },
                set: function(value){
                    validator.validateString(value, 'Playable author');
                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function(){
                    //[id]. [title] - [author]
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            });
            return playable;
        }());
        
        audio = (function(parent){
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function(title, author, length){
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get : function(){
                    return this._length;
                },
                set : function(value){
                    validator.validateIfNumber(value, 'Audio length');
                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function(){
                    return parent.play.call + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        video = (function(parent){
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function(title, author, imdbRating){
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get : function(){
                    return this.imdbRating;
                },
                set : function(value){
                    validator.validateIMDB(value, 'IMDB rating');
                }
            });

            Object.defineProperty(video, 'play', {
                value: function(){
                    return parent.play.call + ' - ' + this.imdbRating;
                }
            });
            return video;
        }(playable));

        function findIndexOfElementID(elementID, collection){
            var i, 
                length;
            for(i = 0, length = collection.length; i < length; i += 1){
                if(collection[i].id === elementID){
                    return i;
                }
            }
            return -1;
        }

        function sortingFunction(firstParameter, secondParameter) {
            return function (first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                }
                else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                }
                else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                }
                else {
                    return 0;
                }
            };
        }


        return{
            getPlayer: function (name){
                return Object.create(player).init(name);
            },
            getPlaylist: function(name){
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length){
                var audioResult = Object.create(audio).init(title, author, length);
                return audioResult;
            },
            getVideo: function(title, author, imdbRating){
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());
return module;
}
var test = solve();
var playlistTest = test.getPlaylist('new playlist');
var audio1 = test.getAudio('audio1','aaa', 5);
var audio2 = test.getAudio('audio2', 'bbb', 3);
playlistTest.addPlayable(audio2);
playlistTest.addPlayable(audio1);
var findByID = playlistTest.getPlayableById(1);
console.log(findByID);
console.log(playlistTest);
playlistTest.removePlayable(audio1);
console.log(playlistTest);