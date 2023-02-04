function alertYourInput() {
	let button = document.createElement("button");
	button.innerHTML = "alert your input";
	button.style.color = "black";
	button.style.backgroundColor = "white";

	button.addEventListener("click", function () {
		let form = document.createElement("form");
		form.id = "alertFormInput";
		let input = document.createElement("input");
		let submitButton = document.createElement("input");
		submitButton.type = "submit";
		submitButton.value = "alert input";


		form.appendChild(input);
		form.appendChild(submitButton);

		form.addEventListener("submit", function () {
			let userInput = input.value;
			alert(userInput);
		});
		document.body.appendChild(form);
	});

	document.body.appendChild(button);
}