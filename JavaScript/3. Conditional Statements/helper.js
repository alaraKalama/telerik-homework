    var a4 = 5;
	var b4 = 6;
	var c4 = 1;
	var rootString;
	var firstRoot;
	var secondRoot;
	var equationString = 
			a4 + 'x^2 + ' + b4 + 'x + ' + c4 + ' = 0';
	var inBrackets = (b4 * b4) - (4 * a4 * c4); 

	firstRoot = (-b4 + Math.sqrt(inBrackets)) / (2 * a4);
	secondRoot = (-b4 - Math.sqrt(inBrackets)) / (2 * a4);
	
	rootString = 'Roots are: ' + firstRoot + ' and ' + secondRoot; 
	console.log(equationString);
	console.log(rootString);