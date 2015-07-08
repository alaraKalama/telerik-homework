function solve() {

    //validating functions

    function isString(name){
        return typeof name === 'string' ||
        (typeof name === 'object' && name.constructor === String);
    }

    function isEmptyObject(obj) {
        for (var property in obj) {
            if (obj.hasOwnProperty(property)) {
                return false;
            }
        }

        return true;
    }

    function isValidType(type){
        return type.length &&
               isString(type) &&
               /^[A-Za-z\d]+$/i.test(type);
    }

    function isValidAttribute(attribute){
        return attribute.length &&
               isString(attribute) &&
               /^[A-Za-z\d\-]+$/i.test(attribute);
    }

    function parseHTML() {
        var output = '<' + this.type,
            keys = [],
            index,
            key,
            len;

        if (!isEmptyObject(this.attributes)) {
            for (key in this.attributes) {
                if (this.attributes.hasOwnProperty(key)) {
                    keys.push(key);
                }
            }

            keys.sort();
            len = keys.length;
            for (index = 0; index < len; index++) {
                output += ' ' +
                          keys[index] +
                          '="' +
                          this.attributes[keys[index]] +
                          '"';
            }
        }

        output += '>';

        if (this.children.length > 0) {
            len = this.children.length;
            for (index = 0; index < len; index++) {
                if (isString(this.children[index])) {
                    output += this.children[index];
                } else {
                    output += this.children[index].innerHTML;
                }
            }
        } else if (this.content) {
            output += this.content;
        }

        output += '</' + this.type + '>';

        return output;
    }

    var domElement = (function () {
        var domElement = {
            get type(){
                return this._type;
            },
            set type(value){
                this._type = value;
            },
            get content(){
                return this._content;
            },
            set content(value){
                this._content = value;
            },
            get attributes(){
                return this._attributes;
            },
            set attributes(value){
                this._attributes = value;
            },
            get children(){
                return this._children;
            },
            set children(value){
                this._children = value;
            },
            get parent(){
                return this._parent;
            },
            set parent(value){
                this._parent = value;
            },

            init: function(type) {
                //check if it is valid type
                if(!isValidType(type)){
                    throw new Error('Invalid type!');
                }

                this.type = type;
                this.parent;
                this.content;
                this.attributes = {};
                this.children = [];
                this.innerHTML;
                return this;
            },

            appendChild: function(child) {
                child.parent = this;
                this.children.push(child);
                return this;
            },

            addAttribute: function(name, value) {
               if(!isValidAttribute(name)){
                throw new Error('Invalid Attribute!');
               }
                this.attribute[name] = value;
                return this;
            },
            removeAttribute: function(attribute) {
                //check if valid attribute
                isValidAttribute();
                if(!(this.attributes[attribute] && isValidAttribute(attribute))){
                    throw new Error('Invalid Attribute');
                }
                delete this.attributes[attribute];
                return this;
            },
      get innerHTML(){
        return parseHTML.call(this);
      }
        };
        return domElement;
    } ());
    return domElement;
}

module.exports = solve;
