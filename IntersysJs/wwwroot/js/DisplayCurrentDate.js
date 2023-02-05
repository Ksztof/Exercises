function showButton3() {
	let button = document.createElement("button");
	button.innerHTML = "Show current Date";
	let currentDate = new Date();
	let daysOfWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
	let toDay = daysOfWeek[currentDate.getDay()];
	button.addEventListener("click", function () {
		alert(currentDate + "and day is: " + toDay);
	});


	document.body.appendChild(button);
}

function button4() {
	let btn4 = document.createElement("button");
	btn4.innerHTML = "reverseWord";

	btn4.addEventListener("click", function () {
		let userWord = prompt("Give me your word");
		for (var i = 0; i < userWord.length; i++) {
			userWord1 = userWord.slice(-1) + userWord.slice(0, -1);
		}
		userWord = userWord1;

		alert(userWord);

	});

	document.body.appendChild(btn4);
}


function testButton() {
	let button5 = document.createElement("button");
	button5.innerHTML = "button5";

	button5.addEventListener("click", function () {
		let form = document.createElement("form");
		form.id = "formId"

		let input = document.createElement("input");

		let submitButton = document.createElement("input");
		submitButton.type = "submit";
		submitButton.value = "Submit";

		form.appendChild(input);
		form.appendChild(submitButton);

		form.addEventListener("submit", function () {
			let inputValue = input.value;
			alert(inputValue);
		})

		document.body.appendChild(form);
	});
	document.body.appendChild(button5);
}