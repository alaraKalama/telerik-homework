//1.Assign all the possible JavaScript literals to different variables.

var str = 'string';
var int = 1234;
var float = 12.34;
var array = [1, 2, 3, 4];
var person = {
    name: 'Ivaylo Kenov',
    age: 26, 
    work: 'Technical Trainer at Telerik'
};
var func = function () { return; };
var nulla = null;
var undefine = undefined;
var variables = [str, int, float, array, person, func, nulla, undefine];

for (var all in variables) {
    console.log(getType(all[all]));
}

function getType(obj) {
    var result = obj;
    result += 'is' + typeof obj;
    return result;
}