
/*
	Write a function a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to Number
		3) it must throw an Error if any of the range params is missing
*/


function primesInRange (start, end) {
	var n,
		primes = [],
		start = +start,
		end = +end,
		lenche = arguments.length;
	if(lenche < 2){
		throw 'Error! There must be a range between two numbers.';
	}
	else if(isNaN(start) || isNaN(end)){
		throw 'Error! Input must be convertible to number.'
	}
	else{
		for(n = start; n <= end; n += 1){
			if(isPrime(n)){
				primes.push(n);
			}
		}
		return primes;
	}

	function isPrime(number){
		var maxDivider = Math.sqrt(number),
		prime = true,
		divider;

		if(number < 2){
			return false;
		}
		for(divider = 2; divider <= maxDivider; divider += 1){
			if(!(number % divider)){
				prime = false;
				break;
			}
		}

		return prime;
	}

}


//console.log(primesInRange(1, 5));
module.exports = primesInRange;



