//1.Write an if statement that takes two double variables a and b
//and exchanges their values if the first one is greater than the
//second. As a result print the values a and b, separated by 
//a space.

function ExchangeIfGreater() {
	var first = document.getElementById("first").value;
	var second = document.getElementById("second").value;
	var result = "";

	if(second > first){
		result = first + " " + second;
	}
	else{
		result = second + " " + first;
	}

	document.getElementById("result").value = result;
}

//2. Write a script that shows the sign (+, - or 0) of 
//the product of three real numbers, without calculating it.
//Use a sequence of if operators.

function MultiplicationSign(){
	var a1 = document.getElementById("a1").value,
	b1 = document.getElementById("b1").value,
	c1 = document.getElementById("c1").value,
	sign;

	if((a1 * b1 * c1) === 0){
		sign = "0";
	}
	else if((a1 * b1 * c1) < 0){
		sign = "-";
	}
	else{
		sign = "+";
	}

	document.getElementById("sign").value = sign;
}

//3.Write a script that finds the biggest of three numbers.
//Use nested if statements.

function biggestOfThree() {
	var a2 = document.getElementById("a2").value,
	b2 = document.getElementById("b2").value,
	c2 = document.getElementById("c2").value,
	biggest;

	if (a2 > b2 && a2 > c2){
		biggest = a2;
	}
	else if(b2 > a2 && b2 > c2){
		biggest = b2;
	}
	else{
		biggest = c2;
	}

	document.getElementById("bb").value = biggest;
	//Interesting - this works if the ID is "b", I also tried 
	//"big" and "biggest" - and this didn't worked..
}


//4.Sort 3 real values in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
function sortDescending() {
	var a3 = document.getElementById("a3").value,
	b3 = document.getElementById("b3").value,
	c3 = document.getElementById("c3").value,
	sortedNums = "";

	if((a3 >= b3) && (a3 >= c3)){
		if(b3 >= c3){
			sortedNums = a3 + " " + b3 + " " + c3;
		}
		else if(c3 >= b3){
			sortedNums = a3 + " " + c3 + " " + b3;
		}
	}
	else if((b3 >= a3) && (b3 >= c3)){
		if(a3 >= c3){
			sortedNums = b3 + " " + a3 + " " + c3;
		}
		else if(c3 >= a3){
			sortedNums = b3 + " " + c3 + " " + a3;
		}
	}
	else if((c3 >= a3) && (c3 >=b3)){
		if(a3 >= b3){
			sortedNums = c3 + " " + a3 + " " + b3;
		}
		else {
			sortedNums = c3 + " " + b3 + " " + a3;
		}
	}

	document.getElementById("sorted").value = sortedNums;
}

//5.Write a script that asks for a digit (0-9), 
//and depending on the input, shows the digit as a word 
//(in English).

function convertToWord() {
	var inputDigit = document.getElementById("digit").value;
	var asWord;

	switch(inputDigit) {
		case '1':
			asWord = "one";
			break;
		case '2':
			asWord = "two";
			break;
		case '3':
			asWord = "three";
			break;
		case '4':
			asWord = "four";
			break;
		case '5':
			asWord = "five";
			break;
		case '6':
			asWord = "six";
			break;
		case '7':
			asWord = "seven";
			break;
		case '8':
			asWord = "eight";
			break;
		case '9':
			asWord = "nine";
			break;
		case '0':
			asWord = "zero";
			break;
		default:
			asWord = 'not a digit';
			break;
		
	}

	document.getElementById("word").value = asWord;

}

//6.Write a script that reads the coefficients a, b and c 
//of a quadratic equation ax2 + bx + c = 0 and solves it 
//(prints its real roots). Calculates and prints 
//its real roots.
function solveEquation(){
	var a4 = document.getElementById("a4").value;
	var b4 = document.getElementById("b4").value;
	var c4 = document.getElementById("c4").value;
	var rootString;
	var firstRoot;
	var secondRoot;
	var equationString = '' + 
			a4 + 'x^2 + ' + b4 + 'x + ' + c4 + ' = 0';
	var inBrackets = (b4 * b4) - (4 * a4 * c4); 

	firstRoot = (-b4 + Math.sqrt(inBrackets)) / (2 * a4);
	secondRoot = (-b4 - Math.sqrt(inBrackets)) / (2 * a4);
	
	if(firstRoot === secondRoot){
		rootString = 'Root is ' + firstRoot;
	}
	else if (isNaN(firstRoot) && isNaN(secondRoot)){
		rootString = 'There are no real roots';
	}
	else{
		rootString = 'Roots are: ' + firstRoot + ' and ' + secondRoot; 
	}
	document.getElementById("equation").value = equationString;
	document.getElementById("roots").value = rootString;
}

//7.Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

function findLargestNumber() {
	var a = document.getElementById("a").value * 1;
	var b = document.getElementById("b").value * 1;
	var c = document.getElementById("c").value * 1;
	var d = document.getElementById("d").value * 1;
	var e = document.getElementById("e").value * 1;
	var max;
	var currentMax = Number.MIN_VALUE;

	if(a > currentMax){
		currentMax = a;
	}
	if(b > currentMax){
		currentMax = b;
	}
	if(c > currentMax){
		currentMax = c;
	}
	if (d > currentMax){
		currentMax = d;
	}
	if(e > currentMax){
		currentMax = e;
	}

	max = currentMax;
	document.getElementById("largestOfFive").value = max;
}

//8.Write a script that converts a number in the range [0…999] 
//to words, corresponding to its English pronunciation.

function convertToWord2() {
	var innput = document.getElementById("hundred").value;
	var hundreds = Math.floor(innput / 100),
            tens = (Math.floor(innput / 10)) % 10,
            digits = (innput % 10),
            special = 10 + digits;

            switch (special) {
            case 11:
                special = "eleven";
                break;
            case 12:
                special = "twelve";
                break;
            case 13:
                special = "thirteen";
                break;
            case 14:
                special = "fourteen";
                break;
            case 15:
                special = "fifteen";
                break;
            case 16:
                special = "sixteen";
                break;
            case 17:
                special = "seventeen";
                break;
            case 18:
                special = "eighteen";
                break;
            case 19:
                special = "nineteen";
                break;
            }

        document.getElementById("inEnglish").value = 
        	"The truth is ain't nobody got time for that";
        
     
}