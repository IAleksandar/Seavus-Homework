let dog = parseInt(prompt("Enter your age: "));
function years(dog){
    let h = dog + 7;
    let d = h - 7;
    console.log("Your dog's age is "+ h + " years. " + d + " is the calculated age" );
    console.log("If your age is: " + d + " ,then your dog's age is: " + h); 
}

years(dog);