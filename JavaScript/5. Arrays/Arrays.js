//1.Write a script that allocates array of 20 integers 
//and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

function IncreaseArrayMembers() {
	var myArray = [];
	for (var i = 0; i < 20; i++) {
		myArray.push(i * 5);
	}
	document.getElementById("Problem1").value = myArray;
	console.log(myArray);
}

IncreaseArrayMembers();

//2.Write a script that compares two char arrays 
//lexicographically (letter by letter).


