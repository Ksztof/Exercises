function createButton2()
{
    let btn = document.createElement("button");
    btn.innerHTML = "Fix Age";
    btn.addEventListener("click", function ()
    {
        let userInput = prompt("Pleas give me array of integers, separated by commas:");
        let userInputArray = userInput.split(",").map(function (item) {
            return parseFloat(item);
        });
        let result = fixage(userInputArray);
        alert(result);
    });

    document.body.appendChild(btn);
}

function fixage(arrayOfIntegers)
{
    let wantedAgeArray = [];
    if (!Array.isArray(arrayOfIntegers)) {
        return 'NA';
    }

    arrayOfIntegers.forEach(number =>
    {
        if (number >= 18 && number <= 60)
        {
            wantedAgeArray.push(number);
        }
       
    });
    if (wantedAgeArray.length === 0) {
        return "NA";
    }
    else
    {
        return wantedAgeArray;
	}
}