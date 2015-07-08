var animal = (function() {
	var animal = {
		init: function(name, age){
			this.name = name;
			this.age = age;
			return this;
		},
		get name(){
			return this._name;
		},
		set name(value){
			if(value.length < 1){
				throw new Error('Too short name');
			}
			this._name = value;
		},
		toString: function(){
			return this.name + ' ' + this.age;
		},
		type : {
			value: 'animal'
		}
	}
	return animal;
}());

var cat = (function(parent){
	var parent = Object.create(parent);
	var cat = Object.create(parent);
	cat.init = function(name, age, sleep){
		parent.init.call(this, name, age);
		this.sleep = sleep;
		return this;
	}

	cat.toString = function(){
		var base = parent.toString.call(this);
		return base + ' ' + this.sleep;
	}
	cat.type = 'cat';

	return cat;
}(animal));

var someAnimal = Object.create(animal).init('pesho', 3);
console.log(someAnimal.type);
var someCat = Object.create(cat).init('gosho', 2, false);
console.log(Object.getPrototypeOf(cat));
console.log(someCat.prototype instanceof Object);
console.log(someCat.type);


