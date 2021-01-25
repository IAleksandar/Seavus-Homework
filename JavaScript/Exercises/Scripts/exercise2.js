let input = parseFloat(prompt("Enter number: "));


function isNumber(){
    if(isNaN(input)){
        console.log("The input is not a number");
    }
    else {
    if(input < 0){
        console.log("The input is negative");
    }
    else if(input > 0){
        console.log("The input is positive");
    }
    else {
        console.log("The input is zero");
    }

    if(input % 2 !== 0){
        console.log("The input is odd");
    }
    else {
        console.log("The input is even");
    }
    let count = 1;
    while (parseInt(input/10)>0){
        debugger;
        input = parseInt(input/10);
        count++;
        
    }
    console.log(count);

}
}

isNumber();