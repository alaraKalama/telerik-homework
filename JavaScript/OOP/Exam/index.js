function solve() { 

    var module = (function(){
        var catalog, 
            bookCatalog,
            mediaCatalog, 
            item, 
            book, 
            media,
            validator,
            errors,
            CONSTANTS;

        CONSTANTS = {
            ITEM_NAME_MIN_LENGTH : 2,
            ITEM_NAME_MAX_LENGTH : 40,
            GENRE_MIN_LENGTH : 2,
            GENRE_MAX_LENGTH : 40,
            MEDIA_MIN_RATING : 1,
            MEDIA_MAX_RATING : 5,
            ISBN_MAGIG_NUMBER_10 : 10,
            ISBN_MAGIG_NUMBER_13 : 13
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
            InvalidDescription: function(name){
                throw new Error(name + 'cannot be an empty string');
            },
            InvalidGenreString: function(name){
                throw new Error(name + 'must be between 2 and 20 chars');
            },
            InvalidStringType: function(name){
                throw new Error(name + ' must be a string value');
            },
            InvalidItemNameLEngth: function(name){
                throw new Error(name + 'must be between 2 and 40 chars');
            },
            NotPositiveNumberError: function(name){
                throw new Error(name + ' must be a positive number');
            },
            InvalidMediaRating: function(name){
                throw new Error(name + ' must be between ' + CONSTANTS.MEDIA_MAX_RATING + 'and ' + CONSTANTS.MEDIA_MIN_RATING);
            },
            InvalidIsbnLength: function(name){
                throw new Error(name + 'must be either ' + CONSTANTS.ISBN_MAGIG_NUMBER_10 + ' or ' + CONSTANTS.ISBN_MAGIG_NUMBER_13);
            },
            InvalidIsbn: function(name){
                throw new Error(name + 'must contain only digits');
            },
            ElementWithIdNotFound: function(name){
                throw new Error('In ' + name + 'element with the provided ID was not found');
            },
            NotAnItemError: function(name){
                throw new Error('The item to add must be of type ' + name);
            }

        };

        validator = {
            validateIfUndefined: function(value, name){
                name = name || 'Value';
                if(value === undefined){
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
            },
            validateItemDescription: function(value, name){
                name = name || 'Value';
                this.validateString(value);
                if(value.length <= 0){
                    errors.InvalidDescription(name);
                }
            },
            validateItemName: function(value, name){
                name = name || 'Value';
                this.validateString(value);
                if(value.length < CONSTANTS.ITEM_NAME_MIN_LENGTH ||
                    value.length > CONSTANTS.ITEM_NAME_MAX_LENGTH){
                    errors.InvalidItemNameLEngth(name);
                }
            },
            validateBookGenre: function(value, name){
                name = name || 'Value';
                this.validateString(value);
                if(value.length < CONSTANTS.GENRE_MIN_LENGTH ||
                    value.length > CONSTANTS.GENRE_MAX_LENGTH){
                    errors.InvalidGenreString(name);
                }
            },
            validateIfPositiveNumber: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                if(typeof value !== 'number' || value < 0){
                    errors.NotPositiveNumberError(name);
                }
            },
            validateRatig: function(value, name){
                name = name || 'Value';
                this.validateIfUndefined(value, name);
                this.validateIfNumber(value);
                if(value < CONSTANTS.MEDIA_MIN_RATING ||
                    value > CONSTANTS.MEDIA_MIN_RATING){
                    errors.InvalidMediaRating(name);
                }
            },
            validateISBN: function(value, name){
                name = name || 'Value';
                var i, len, currentEl, valueLen;
                this.validateString(value);
                valueLen = value.length;

                if(valueLen !== CONSTANTS.ISBN_MAGIG_NUMBER_10){
                    if(valueLen !== CONSTANTS.ISBN_MAGIG_NUMBER_13){
                        errors.InvalidIsbnLength(name);
                    }
                }

                for(i = 0, len = value.length; i < len; i += 1){
                    currentEl = value[i];

                    if(isNaN(+currentEl)){
                        errors.InvalidIsbn(name);
                    }
                }
            },
            validateItemsToAddToCatalog: function(value, typeOfCatalog){
                this.validateIfUndefined(value, 'Items to add to Catalog');
                var arrayOfItems = [],
                    tempItems = [],
                    i, len;

                if( Object.prototype.toString.call( value ) === '[object Array]' ){
                    if(value.length <= 0){
                        throw new Error('Array with items to add is empty!');
                    }
                    tempItems = value.slice();
                }
                if(Object.prototype.toString.call( value ) === '[object Object]'){
                    tempItems.push(value);
                    
                }
                if(typeOfCatalog === 'Catalog'){
                    tempItems.forEach(this.validateIfItem);
                   
                }
                if(typeOfCatalog === 'BookCatalog'){
                    tempItems.forEach(this.validateIfBook);

                }
                if(typeOfCatalog === 'MediaCatalog'){
                    tempItems.forEach(this.validateIfMedia);
                }
                arrayOfItems = tempItems.slice();
                return arrayOfItems;
            },
            validateID: function(id){
                this.validateIfUndefined(id);
                if(typeof id !== 'number'){
                    id = null;
                }
                return id;
            },
            validateIfItem: function(item, name){
                name = name || 'Value';
                if(item.type !== 'item' ||
                    item.type !== 'book' ||
                    item.type !== 'media'){
                    errors.NotAnItemError('item, book or media');
                }
            },
            validateIfBook: function(item, name){
                name = name || 'Value';
                if(item.type !== 'book'){
                    errors.NotAnItemError('book');
                }
            },
            validateIfMedia: function(item, name){
                name = name || 'Value';
                if(item.type !== 'media'){
                    errors.NotAnItemError('media');
                }
            },
        };

        item = (function(){
            var item = Object.create({});
            var currenmtID = 0;

            Object.defineProperty(item, 'init', {
                value: function(name, description){
                    this.name = name;
                    this.description = description;
                    this._id = currenmtID += 1;
                    this.type = 'item';
                    return this;
                }
            });

            Object.defineProperty(item, 'name', {
                get : function(){
                    return this._name;
                },
                set : function(value){
                    validator.validateItemName(value, 'Item name');
                    this._name = value;
                }
            });

            Object.defineProperty(item, 'description', {
                get : function(){
                    return this._description;
                },
                set : function(value){
                    validator.validateItemDescription(value, 'Item description');
                    this._description = value;
                }
            });

            Object.defineProperty(item, 'id', {
                get : function(){
                    return this._id;
                }
            });
            
            return item;
        }());

        book = (function(parent){
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function(name, isbn, genre, description){
                    parent.init.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;
                    this.type = 'book';

                    return this;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function(){
                    return this._genre;
                },
                set: function(value){
                    validator.validateBookGenre(value, 'Book genre');
                    this._genre = value;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function(){
                    return this._isbn;
                },
                set : function(value){
                    validator.validateISBN(value, 'ISBN');
                    this._isbn = value;
                }
            });
            return book;
        }(item));

        media = (function(parent){
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function(name, duration, rating, description){
                    parent.init.call(this, name, description);
                    this.duration = duration;
                    this.rating = rating;
                    this.type = 'media';
                    return this;
                }
            });

            Object.defineProperty(media, 'duration',{
                get: function(){
                    return this._duration;
                },
                set: function(value){
                    validator.validateIfPositiveNumber(value, 'Media duration');
                    this._duration = value;
                }
            });

            Object.defineProperty(media, 'rating',{
                get: function(){
                    return this._rating;
                },
                set: function(value){
                    validator.validateRatig(value, 'Media rating');
                    this._rating = value;
                }
            });
            return media;
        }(item));

        catalog = (function(){
            var catalog = Object.create({});
            var currenmtID = 0;

            Object.defineProperty(catalog, 'init',{
                value: function(name){
                    this.name = name;
                    this._id = currenmtID += 1;
                    this._items = [];
                    this.type = 'Catalog';
                    return this;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get : function(){
                    return this._name;
                },
                set : function(value){
                    validator.validateItemName(value, 'Catalog name');
                    this._name = value;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function(){
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function(itemsToAdd){
                    var itemsToADD = validator.validateItemsToAddToCatalog(itemsToAdd, this.type);
                    var i, len;
                    for(i = 0, len = itemsToADD.length; i < len; i += 1){
                        this._items.push(itemsToADD[i]);
                    }
                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function(id){
                    //validator.validateIfPositiveNumber(id);
                    var foundIndex = findIndexOfElementID(id, this._items);
                    if(foundIndex < 0){
                        return null;
                    }
                    return this._items[foundIndex];

                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    validator.validateString(pattern, 'Search pattern');

                    var i, len, currentItem;
                    var searchResults = [];
                    len = this._items.length;
                    for(i = 0; i < len; i += 1){
                        currentItem = this._items[i];
                        if(currentItem.name.indexOf(pattern) > -1 ||
                            currentItem.description.indexOf(pattern) > -1){
                            searchResults.push(currentItem);
                        }
                    }
                    return searchResults;
                }
            });

            return catalog;
        }());

        bookCatalog = (function(parent){
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init',{
                value: function(name){
                    parent.init.call(this, name);
                    this.type = 'BookCatalog';
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add',{
                value: function(itemsToAdd){
                    return parent.add.call(this, itemsToAdd);
                }
            });

            Object.defineProperty(bookCatalog, 'getGenres',{
                value: function(){
                    var i, len,
                        genres = [];
                    len = this._items.length;
                    for(i = 0; i < len; i += 1){
                        if(genres.indexOf(this._items[i].genre) < 0){
                            genres.push(this._items[i].genre);
                        }
                    }
                    return genres;
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function(parent){
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init',{
                value: function(name){
                    parent.init.call(this, name);
                    this.type = 'MediaCatalog';
                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'add',{
                value: function(itemsToAdd){
                    return parent.add.call(this, itemsToAdd);
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop',{
                value: function(count){
                    validator.validateIfPositiveNumber(count, 'getTop count param');
                    var sortedItems = this._items.sort(function(a,b){
                        return b.rating - a.rating;
                    });
                    var topItems = sortedItems.splice(0, count);

                }
            });


            return mediaCatalog;
        }(catalog));

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


        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book).init(name, isbn, genre, description);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog).init(name);
            }
        };

    }()); 
    return module;       
}
var module = solve();

var catalog = module.getBookCatalog('John\'s catalog');
var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add([]);
catalog.add(book2);
console.log('test find');
console.log(catalog.find(book1.id));
//returns book1

console.log('test search');
console.log(catalog.search('JS')); 
// returns book2

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js')); 
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []





