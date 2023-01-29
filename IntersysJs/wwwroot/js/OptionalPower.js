function createButton()
{
    let btn = document.createElement("button");
    btn.innerHTML = "Optional Power";
    btn.addEventListener("click", function () {
        let num1 = parseFloat(prompt("Give me number1:"));
        let num2 = parseFloat(prompt("Give me number2: "));
        let result = askUser();
        if (result) {
           let powResult = optionalPow(num1, num2)
        }
        else
        {
            let powResult = optionalPow(num2, num1)
        }

        alert(`${powResult}`)

    });

    document.body.appendChild(btn);

}


function askUser()
{
    let question = confirm("Do you like like programming");
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