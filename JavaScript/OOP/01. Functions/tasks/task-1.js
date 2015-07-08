/* 
	Write a function that sums an array of numbers:
	numbers must be always of type Number
	returns `null` if the array is empty
	throws Error if the parameter is not passed (undefined)
	throws if any of the elements is not convertible to Number	
*/


function sum (array) {
	if(array.length === 0){
		return null;
	}
	else if(array === undefined){
		throw 'error!';
	}
	else if (!array.every(function(item){
		return !isNaN(item);
	})) {
		throw 'error!';
	}

	return array.reduce(function(s,n){
		return s += parseInt(n);
	},0);
}
module.exports = sum;
//var arr = ["1","2"];
//console.log(sum(arr));