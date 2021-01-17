let cash = parseInt(prompt("Enter cash: "));
let request = parseInt(prompt("Enter how much money would you like to withdrawn: "));

function bank(){
    let withdrawn = request;
    let left = cash - request;
    if(request > cash){
        console.log("Not enough money");
    }
    else {
        console.log("Withdrawn: " + withdrawn);
        console.log("Left: " + left);
    }
}

bank();