let buttonPrint = document.getElementsByTagName("input")[2];
let firstNameInput = prompt("Enter first name: ");
let lastNameInput = prompt("Enter last name: ");



let myDiv = document.getElementById("myDiv");
let div = document.getElementById("content");

function validate(fName, lName){
    fName = firstNameInput.length;
    lName = lastNameInput.length;
    let counter = 5;
    if (fName < 5 && lName < 5){
        console.log(`${div.innerHTML}`);
        div.innerHTML = `You must enter min 5 letters !`;
    }
    else {
        console.log(`${div.innerHTML}`);
        div.innerHTML = `Greeting ${firstNameInput} ${lastNameInput}`;
    }
}

myDiv.addEventListener("click", function(){
    firstName = document.getElementsByTagName("input")[0];
    lastName = document.getElementsByTagName("input")[1];
    firstName.value = firstNameInput;
    lastName.value = lastNameInput;
    validate(firstName, lastName);
  //  div.innerHTML = `Greeting ${firstNameInput} ${lastNameInput}`;
});




div.addEventListener("mouseover", function(){
    div.innerHTML = " ";
});


