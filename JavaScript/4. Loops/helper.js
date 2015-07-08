var input = "4, 5, 7, 5, 34, 2";

	var array = input.split(", ").map(Number);
	for (var i = 0; i < array.length; i++) {
		console.log(array[i]);
	}
	console.log(input);