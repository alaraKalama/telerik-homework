//1.Write an expression that checks if given integer is odd or even.
function isOdd(){

    var input = document.getElementById("input").value;
    var result;

    if (isNaN(input)) {
        result = "NaN";
    }
    else {
        result = input % 2 === 0 ? "false" : "true";
    }
    document.getElementById("result").value = result;
}

//2.Write a boolean expression that checks for given integer 
//if it can be divided (without remainder) by 7 and 5 in the 
//same time.

function divisibleBy7And5(){

	var input = document.getElementById("toDivide").value;
	var result;

	if (isNaN(input)){
		result = NaN;
	}
	else{
		result = input % 5 === 0 && input % 7 === 0 ? "true" : "false";
	}

	document.getElementById("result2").value = result;
}

//3.Write an expression that calculates 
//rectangle’s area by given width and height.
function calculateRectangleArea(){

	var width = document.getElementById("widthRectangle").value;
	var height = document.getElementById("heightRectangle").value;
	var area;

	if(isNaN(width) || isNaN(height)){
		area = NaN;
	}
	else{
		area = width * height;
	}

	document.getElementById("area").value = area;
}

//4.Write an expression that checks for given integer if its 
//third digit (right-to-left) is 7.
function CheckThirdtDigit(){

	var number = document.getElementById("integer").value;
	number = number + "";
	var isSeven;

	if(number.length >= 3){
		var reverse = number.split("").reverse().join("");
		isSeven = reverse[2] === "7" ? "true" : "false";
	}

	document.getElementById("isItSeven").value = isSeven;
}

//5.Write a boolean expression for finding if the bit #3 
//(counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

function findThirdBit(){
	var dec = document.getElementById("convertToBinary").value;
	var binary = (dec >>> 0).toString(2);
	var reversed = binary.split("").reverse().join("");
	var thirdBit = reversed[2];
	document.getElementById("binary").value = binary;
	document.getElementById("thirdBit").value = thirdBit;
}

//6.Write an expression that checks if given point P(x, y) 
//is within a circle K({0,0}, 5). //{0,0} is the centre 
//and 5 is the radius

function pointInCircle(){
	var x = parseFloat(document.getElementById("x").value);
	var y = parseFloat(document.getElementById("y").value);
	var r = 5;
	var circle;

	if ((x * x) + (y * y) < (r * r)) {
		circle = true;
	}
	else{
		circle = false;
	}
	document.getElementById("inCircle").value = circle;

}

//7.Write an expression that checks if given 
//positive integer number n (n ≤ 100) is prime.

function isPrime(){
	var toCheck = document.getElementById("ifPrime").value;
	var max = Math.sqrt(toCheck);
	var divider = 2;
	var answer = true;

	if(toCheck <= 1){
		answer = false;
 	}

 	while ((answer === true) && divider <= max) {
        if (toCheck % divider === 0) {
            answer = false;
        }
        divider++;
    }

    document.getElementById("answer").value = answer;
}

//8.Write an expression that calculates trapezoid's area 
//by given sides a and b and height h.
function trapezoidArea(){
	var a = parseFloat(document.getElementById("a").value);
	var b = parseFloat(document.getElementById("b").value);
	var h = parseFloat(document.getElementById("h").value);
	var s = ((a + b) / 2) * h;
	document.getElementById("trapezoid").value = s;
}

//9.Write an expression that checks for given point P(x, y) 
//if it is within the circle K( (1,1), 3) and 
//out of the rectangle R(top=1, left=-1, width=6, height=2).
function inCircleOutsideRactangle(){
	var x = document.getElementById("x2").value;
	var y = document.getElementById("y2").value;
	var cx = 1;
	var cy = 1;
	var r = 3;
	var inTheCircle;
	var inTheRectangle;
	var yesno;

	inTheCircle = 
		((x * x) - (2 * x * cx) + (cx * cx)) + 
		((y * y) - (2 * y * cy) + (cy * cy)) <= r * r;
	inTheRectangle = 
		((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1));

	if((inTheCircle === true) && (inTheRectangle === false)){
		yesno = "yes";
	}
	else{
		yesno = "no";
	}

	document.getElementById("where").value = yesno;

}