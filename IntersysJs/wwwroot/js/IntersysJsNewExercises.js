function exercise1()
{
	let formAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise1";
	button.style.color = "black";
	button.style.backgroundColor = "white";
	button.style.display = "inline-block";

	button.addEventListener("click", function ()
	{
		if (!formAdded)
		{
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

			form.addEventListener("submit", function ()
			{
				let userInput = input.value;
				alert(userInput);
			});
		}
	});
	document.body.appendChild(button);
}


function exercise2()
{
	let formAdded = false;
	let button = document.createElement("button")
	button.innerHTML = "exercise2";

	button.addEventListener("click", function ()
	{
		if (!formAdded)
		{
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

			form.addEventListener("submit", function (event)
			{
				event.preventDefault();
				createTable(form, input.value);
			});
		}
	});
	document.body.appendChild(button);

}


function sendData(url, data, type, successCallback)
{
	$.ajax({
		type: type,
		url: url,
		contentType: 'application/json; charset=utf-8',
		data: (type === 'POST') ? JSON.stringify(data) : data,
		success: function (response)
		{
			console.log("sendData success:", response);
			if (successCallback)
			{
				successCallback(response);
			}
		}
	});
}


function exercise3() {
	let formAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise3";

	button.addEventListener("click", function ()
	{
		if (!formAdded)
		{
			let form = document.createElement("form");
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "Submit";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function (e)
			{
				e.preventDefault();
				let inputAsNumber = parseFloat(input.value);
				if (isNaN(inputAsNumber) || isNaN(input.value))
				{
					alert("Please enter number")
				} else {
					var data = { UserInput: inputAsNumber };
					sendData('/Intersys/ThirdExercise', data, 'POST', function (response)
					{
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
	button.style.display = "inline-block";


	button.addEventListener("click", function ()
	{
		if (!formAdded)
		{
			let form = document.createElement("form");
			let input = document.createElement("input");
			let submitButton = document.createElement("input");
			submitButton.type = "submit";
			submitButton.value = "Submit";

			form.appendChild(input);
			form.appendChild(submitButton);
			document.body.appendChild(form);
			formAdded = true;

			form.addEventListener("submit", function (e)
			{
				e.preventDefault();
				let inputAsNumber = parseFloat(input.value);
				if (isNaN(inputAsNumber) || isNaN(input.value) || inputAsNumber <= 0 || inputAsNumber > 100) {
					alert("Please enter number from range 1 to 100")
				} else {
					let data = { UserInput: inputAsNumber };
					sendData('/Intersys/FourthExercise', data, 'POST', function (response)
					{
						console.log("successCallback response:", response);
						let user = response.firstName + " " + response.lastName;
						createTable(form, user)
					});
				}
			});
		}
	});

	document.body.appendChild(button);
}

function exercise5()
{
	let tableAdded = false;
	let button = document.createElement("button");
	button.innerHTML = "exercise5";
	let div = document.createElement("div");


	button.addEventListener("click", function () {

		if (!tableAdded)
		{
			sendData('/Intersys/FifthExercise', {}, 'GET', function (response)
			{

				let form = document.createElement("form");

				let input1 = document.createElement("input");
				let input2 = document.createElement("input");

				let submitButton = document.createElement("input");
				submitButton.type = "submit";
				submitButton.value = "Submit";


				form.appendChild(input1);
				form.appendChild(input2);
				form.appendChild(submitButton);
				div.insertBefore(form, div.firstChild);

				let users = response;
				let table = document.createElement("table");
				table.style.border = "4px solid blue";
				table.width = "100%";
				let headerRow = document.createElement("tr");
				let firstNameHeaderCell = document.createElement("th");
				firstNameHeaderCell.innerHTML = "First Name";
				headerRow.appendChild(firstNameHeaderCell);
				let lastNameHeaderCell = document.createElement("th");
				lastNameHeaderCell.innerHTML = "Last Name";
				headerRow.appendChild(lastNameHeaderCell);
				table.appendChild(headerRow);

				for (var i = 0; i < users.length; i++)
				{
					let row = document.createElement("tr");
					let firstNameCell = document.createElement("td");
					firstNameCell.style.border = "2px solid blue";
					firstNameCell.style.margin = "2px 0";
					firstNameCell.innerHTML = users[i].firstName;
					row.appendChild(firstNameCell);
					let lastNameCell = document.createElement("td");
					lastNameCell.style.border = "2px solid blue";
					lastNameCell.style.margin = "2px 0";
					lastNameCell.innerHTML = users[i].lastName;
					row.appendChild(lastNameCell);
					table.appendChild(row);
				}
				tableAdded = true;
				div.appendChild(table);

				form.addEventListener("submit", function (e)
				{
					e.preventDefault();
					let firstName = input1.value.trim();
					let lastName = input2.value.trim();
					if (firstName === "" || lastName === "")
					{
						alert("Give me some input.");
					}
					else
					{
						let data = { FirstName: firstName, LastName: lastName };
						sendData('/Intersys/FifthExercise', data, 'POST', function (response)
						{
							console.log("successCallback response:", response);
							let firstName = response.firstName;
							let lastName = response.lastName
							let row = document.createElement("tr");
							let firstNameCell = document.createElement("td");
							firstNameCell.style.border = "2px solid blue";
							firstNameCell.style.margin = "2px 0";
							firstNameCell.innerHTML = firstName;
							row.appendChild(firstNameCell);

							let lastNameCell = document.createElement("td");
							lastNameCell.style.border = "2px solid blue";
							lastNameCell.style.margin = "2px 0";
							lastNameCell.innerHTML = lastName;
							row.appendChild(lastNameCell);

							table.appendChild(row);
						});
					}
				});
			});
		}
	});

	document.body.appendChild(div);
	div.appendChild(button);
}


function createTable(yourForm, input)
{
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