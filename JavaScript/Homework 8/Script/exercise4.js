$(document).ready(function(){
    let firstNumber = $("#number1");
    let secondNumber = $("#number2");
    let thirdNumber = $("#number3");
 
    let button = $("#button");
    let heading = $("#heading");
    
    button.click(function(){
    
    let average = ((firstNumber.val() + secondNumber.val() + thirdNumber.val()) / 3);
    debugger;
    if (average < 10){
        heading.css("color", "red");
        heading.html(`<h1>The average is below 10: ${average}</h1>`);

    } 
    else {
        heading.css("color", "green");
        heading.html(`<h1>The average is above 10: ${average}</h1>`);

    }

    console.log(firstNumber.val());
    console.log(secondNumber.val());
    console.log(thirdNumber.val());
    console.log(average);

    });
    
});



//NE JA RACUNA AVERAGE