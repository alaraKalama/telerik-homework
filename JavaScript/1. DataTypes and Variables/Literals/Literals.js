var string = 'string';
var integer = 42;
var floating = 3.14159;
var arr = [1, 2, 3];
var object = {name: 'Ivaylo Kenov', age: 26};
var bool = true;
var nullable = null;
var notdefined = undefined;

var all =
 [string, integer, floating, arr, object, bool, nullable, notdefined];

for(var thing in all){
	console.log(typeof(all[thing]) + ' is ' + all[thing]);
}