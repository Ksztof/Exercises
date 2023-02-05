function createButtonExercise() {
	let button = document.createElement("button");
	button.innerHTML = "input form";

	button.addEventListener("click", function () {
		let form = document.createElement("form");
		form.setAttribute("type", "submit")

		let input = document.createElement("input");
		input.setAttribute("")

		form.appendChild(input);
	});
	document.body.appendChild(form);
}