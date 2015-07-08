//1.Write a script that prints all the numbers from 1 to N.
function PrintNumbers(){
	var n = document.getElementById("N").value;
	var result1 = "";

	for (var i = 1; i <= n; i++) {
		result1 += i + ", ";
	}

	console.log(result1);
	document.getElementById("result1").value = result1;
}

//2.Write a script that prints all the numbers from 1 to N,
//that are not divisible by 3 and 7 at the same time

function PrintNumbers2(){
	var n2 = document.getElementById("N2").value;
	var result2 = "";

	for (var i = 1; i <= n2; i++) {
		if (!(!(i % 3) && !(i % 7))){
			result2 += i + ", ";
		}
	}

	document.getElementById("result2").value = result2;
	console.log(result2);
}

//3.Write a script that finds the max and min number 
//from a sequence of numbers.
function MinMax(){
	var input = document.getElementById("sequence").value;
	var min = Number.MAX_VALUE;
	var max = Number.MIN_VALUE;

	var array = input.split(", ").map(Number);
	for (var i = 0; i < array.length; i++) {
		if(array[i] > max){
			max = array[i];
		}

		if(array[i] < min){
			min = array[i];
		}
	}

	document.getElementById("min").value = min;
	document.getElementById("max").value = max;
}

//4.Write a script that finds the lexicographically 
//smallest and largest property in document, window 
//and navigator objects.
function Lexicographically(){
	
}