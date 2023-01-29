



function createButton() {
    var btn = document.createElement("button");
    btn.innerHTML = "Optional Power";
    btn.addEventListener("click", function () {
        var num1 = parseFloat(prompt("Give me number1:"));
        var num2 = parseFloat(prompt("Give me number2: "));
    });
    document.body.appendChild(btn);
}


function optionalPow(a, b) {
    
}