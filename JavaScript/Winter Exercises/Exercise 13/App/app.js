var today = new Date();
let yyyy = today.getFullYear();

function calculateAge(birthyear, currentyear){
    let age = currentyear - birthyear;
    console.log("You are " + age + " years old");
}

calculateAge(1994,yyyy);
calculateAge(1999,yyyy);
calculateAge(1990,yyyy);