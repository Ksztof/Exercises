function createButton()
{
    var btn = document.createElement("button");
    btn.innerHTML = "Optional Power";
    btn.addEventListener("click", function () {
        var num1 = parseFloat(prompt("Give me number1:"));
        var num2 = parseFloat(prompt("Give me number2: "));
        var result = askUser();
        if (result) {
           var powResult = optionalPow(num1, num2)
        }
        else
        {
            var powResult = optionalPow(num2, num1)
        }

        alert(`${powResult}`)

    });

    document.body.appendChild(btn);

}


function askUser()
{
    var question = confirm("Do you like like programming");
    if (question)
    {
        return true;
    }
    else
    {
        return false;
	}
}


function optionalPow(num1, num2) {
    return Math.pow(num1, num2)
}