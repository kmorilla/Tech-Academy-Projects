
//Pizza Size, Crust, Sauce, and Cheese

function getReceipt() {
	var text1 = " ";
	var runningTotal = 0;
	var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("size");
	for (var i = 0; i < sizeArray.length; i++) {
		if (sizeArray[i].checked) {
			var selectedSize = sizeArray[i].value;
			text1 = text1+selectedSize+"<br>";
		}
	}
	if (selectedSize === "Personal Size") {
		sizeTotal = 6;
	} else if (selectedSize === "Medium Size") {
		sizeTotal = 10;
	} else if (selectedSize === "Large Size") {
		sizeTotal = 14;
	} else if (selectedSize === "Extra Large Size") {
		sizeTotal = 16;
	}
	runningTotal = sizeTotal;
	getCrust(runningTotal,text1); 
};	


function getCrust(runningTotal,text1) {
	var crustTotal = 0;
	var crustArray = document.getElementsByClassName("crust");
	for (var j = 0; j < crustArray.length; j++) {
		if (crustArray[j].checked) {
			var selectCrust = crustArray[j].value;
			text1 = text1+selectCrust+"<br>";
		}
	}
	if (selectCrust === "Cheese Stuffed Crust") {
		crustTotal = 3;
	}
	runningTotal = (runningTotal + crustTotal);
	document.getElementById("show-text").innerHTML=text1;
	document.getElementById("total-price").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
	getSauce(runningTotal,text1); 
};	


function getSauce(runningTotal,text1) {
	var sauceTotal = 0;
	var sauceArray = document.getElementsByClassName("sauce");
	for (var j = 0; j < sauceArray.length; j++) {
		if (sauceArray[j].checked) {
			var selectSauce = sauceArray[j].value;
			text1 = text1+selectSauce+"<br>";
		}
	}
	
	runningTotal = (runningTotal + sauceTotal);
	document.getElementById("show-text").innerHTML=text1;
	document.getElementById("total-price").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
	getCheese(runningTotal,text1); 
};	


function getCheese(runningTotal,text1) {
	var cheeseTotal = 0;
	var cheeseArray = document.getElementsByClassName("cheese");
	for (var j = 0; j < cheeseArray.length; j++) {
		if (cheeseArray[j].checked) {
			var selectCheese = cheeseArray[j].value;
			text1 = text1+selectCheese+"<br>";
		}
	}
	if (selectCheese === "Extra Cheese") {
		cheeseTotal = 3;
	}
	runningTotal = (runningTotal + cheeseTotal);
	document.getElementById("show-text").innerHTML=text1;
	document.getElementById("total-price").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
	getMeat(runningTotal,text1); 
};	

// Meat and Veggies

function getMeat(runningTotal,text1) {
	var meatTotal = 0;
	var selectedMeat = [];
	var meatArray = document.getElementsByClassName("meats");
	for (var j = 0; j < meatArray.length; j++) {
		if (meatArray[j].checked) {
			selectedMeat.push(meatArray[j].value);
			console.log("selected meat item: ("+meatArray[j].value+")");
			text1 = text1+meatArray[j].value+"<br>";
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
	runningTotal = (runningTotal + meatTotal);
	document.getElementById("show-text").innerHTML=text1;
	document.getElementById("total-price").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
	getVeggies(runningTotal,text1);
};


function getVeggies(runningTotal,text1) {
	var veggiesTotal = 0;
	var selectedVeggies = [];
	var veggiesArray = document.getElementsByClassName("veggies");
	for (var j = 0; j < veggiesArray.length; j++) {
		if (veggiesArray[j].checked) {
			selectedVeggies.push(veggiesArray[j].value);
			console.log("selected veggies item: ("+veggiesArray[j].value+")");
			text1 = text1+veggiesArray[j].value+"<br>";
		}
	}
	var veggiesCount = selectedVeggies.length;
	if (veggiesCount > 1) {
		veggiesTotal = (veggiesCount - 1);
	} else {
		veggiesTotal = 0;
	}
	runningTotal = (runningTotal + veggiesTotal);
	document.getElementById("show-text").innerHTML=text1;
	document.getElementById("total-price").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
};



// Cancel Button

function getClear() {
	document.getElementById("menu").reset();
	text1 = ""
	document.getElementById("show-text").innerHTML = text1;
	document.getElementById("total-price").innerHTML = " "
};

