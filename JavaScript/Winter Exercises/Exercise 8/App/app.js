let n1 = parseInt(prompt("Enter first number: "));
let n2 = parseInt(prompt("Enter second number: "));

let sum = n1 + n2;



function check(){
    if ((n1 > 30 || n2 > 30) || sum === 50)
        {
            console.log("true");
        }
    else {
        console.log("Entered numbers don't accomplish the following reqirements");
    }
}

check();