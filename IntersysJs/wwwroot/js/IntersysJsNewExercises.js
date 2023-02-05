function exercise1() {
	let formAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise1";
	button.style.color = "black";
	button.style.backgroundColor = "white";

	button.addEventListener("click", function () {
		if (!formAdded) {
			let form = document.createElement("form");
			form.id = "alertFormInput";
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "alert input";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function () {
				let userInput = input.value;
				alert(userInput);
			});
		}
	});
	document.body.appendChild(button);
}


function exercise2() {
	let formAdded = false;
	let button = document.createElement("button")
	button.innerHTML = "exercise2";

	button.addEventListener("click", function () {
		if (!formAdded) {
			let form = document.createElement("form");
			form.id = "exercise2FormId";
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "add to table";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function (event) {
				event.preventDefault();
				createTable(form, input.value);
			});
		}
	});
	document.body.appendChild(button);

}


function sendData(url, data, successCallback) {
	$.ajax({
		type: "POST",
		url: url,
		contentType: 'application/json; charset=utf-8',
		data: JSON.stringify(data),
		success: function (response) {
			console.log("sendData success:", response);
			if (successCallback) {
				successCallback(response);
			}
		}
	});
}


function exercise3() {
	let formAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise3";

	button.addEventListener("click", function () {
		if (!formAdded) {
			let form = document.createElement("form");
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "Submit";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function (e) {
				e.preventDefault();
				let inputAsNumber = parseFloat(input.value);
				if (isNaN(inputAsNumber) || isNaN(input.value)) {
					alert("Please enter number")
				} else {
					var data = { UserInput: inputAsNumber };
					sendData('/Intersys/ThirdExercise', data, function (response) {
						console.log("successCallback response:", response);
						//let responseData = JSON.parse(response);
						let doubleUserInput = response.doubleUserInput;
						createTable(form, doubleUserInput)
					});
				}
			});
		}

	});

	document.body.appendChild(button);

}

function exercise4() {
	let formAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise4";

	button.addEventListener("click", function () {
		if (!formAdded) {
			let form = document.createElement("form");
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "Submit";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function (e) {
				e.preventDefault();
				let inputAsNumber = parseFloat(input.value);
				if (isNaN(inputAsNumber) || isNaN(input.value) || inputAsNumber <= 0 || inputAsNumber > 100) {
					alert("Please enter number from range 1 to 100")
				} else {
					var data = { UserInput: inputAsNumber };
					sendData('/Intersys/FourthExercise', data, function (response) {
						console.log("successCallback response:", response);
						let firstName = response.firstName + " " + response.lastName;
						createTable(form, firstName)
					});
				}
			});
		}
	});

	document.body.appendChild(button);

}











function createTable(yourForm, input) {
	let userInput = input;
	let table = document.createElement("table");
	let headerRow = document.createElement("tr");
	let headerCell = document.createElement("th");

	table.style.border = "2px solid blue";
	table.style.margin = "2px 0";
	headerCell.innerHTML = userInput;
	headerRow.appendChild(headerCell);
	table.appendChild(headerRow);
	yourForm.appendChild(table);
}

/*function sendData(url, data, successCallback) {
	var xhr = new XMLHttpRequest();
	xhr.open('POST', url, true);
	xhr.setRequestHeader('Content-Type', 'application/json; charset=UTF-8');
	xhr.onload = function () {
		if (xhr.status === 200) {
			console.log('sendData success:', xhr.response);
			if (successCallback) {
				successCallback(xhr.response);
			}
		}
	};
	xhr.send(JSON.stringify(data));
}*/