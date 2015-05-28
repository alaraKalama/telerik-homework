	var x = 1;
	var y = 4;
	var cx = 1;
	var cy = 1;
	var r = 3;
	var inTheCircle;
	var inTheRectangle;
	var yesno;

	inTheCircle = 
		((x * x) - (2 * x * kx) + (kx * kx)) + 
		((y * y) - (2 * y * ky) + (ky * ky)) <= r * r;
	inTheRectangle = 
		((x >= -1) && (x <= 5)) && ((y <= 1) && (y >= -1));

	if((inTheCircle === true) && (inTheRectangle === false)){
		yesno = "yes";
	}
	else{
		yesno = "no";
	}

	document.getElementById("where").value = yesno;