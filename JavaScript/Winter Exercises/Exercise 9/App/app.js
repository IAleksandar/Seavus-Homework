let number = parseFloat(prompt("Enter number: "));

function check(){
    if(number%3==0){
        console.log("Entered number is divisible by 3");
    }
    else {
        console.log("Entered number isn't divisible by 3");
    }
}

check();