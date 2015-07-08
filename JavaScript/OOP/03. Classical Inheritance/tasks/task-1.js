function solve() {
    var Person = (function () {
        var errors = {
            InvalidAgeError : function(){
                throw new Error ('Age should be between 0 and 150');
            },
            InvalidNameError : function(){
                throw new Error ('Names should contain only english letters and be between 3 and 20 chars long');
            }
        };

        function validateName(name){
            var regex = /^[A-Za-z]{3,20}$/;
            if(!regex.test(name)){
                errors.InvalidNameError();
            }
        }

        function validateAge(age){
            age = +age;
            if(age < 0 || age > 150){
                errors.InvalidAgeError();
            }
        }

        function Person(firstname, lastname, age) {
            var _firstname, _lastname, _age;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Person.prototype.introduce = function(){
                return 'Hello! My name is ' + this.fullname +
                ' and I am ' + this.age + '-years-old';
        };

        Object.defineProperty(Person.prototype, 'firstname',{
            get : function(){
                return this._firstname;
            },
            set : function(value){
                validateName(value);
                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get : function(){
                return this._lastname;
            },
            set : function(value){
                validateName(value);
                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get : function(){
                return this._age;
            },
            set : function(value){
                validateAge(value);
                this._age = value;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get : function(){
                return this.firstname + ' ' + this.lastname;
            },
            set : function(value){
                var names = value.split(' ');
                this.firstname = names[0];
                this.lastname = names[1];
            }
        });
        return Person;
    } ());
    
    return Person;

}
module.exports = solve;
