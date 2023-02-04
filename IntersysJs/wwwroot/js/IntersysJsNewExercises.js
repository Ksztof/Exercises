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

			form.addEventListener("submit", function (event) {
				event.preventDefault();

				let userInput = input.value;
				let table = document.createElement("table");
				let headerRow = document.createElement("tr");
				let headerCell = document.createElement("th");

				table.style.border = "2px solid blue";
				table.style.margin = "2px 0";
				headerCell.innerHTML = userInput;
				headerRow.appendChild(headerCell);
				table.appendChild(headerRow);
				form.appendChild(table);
			});
		}
	});
	document.body.appendChild(button);

}