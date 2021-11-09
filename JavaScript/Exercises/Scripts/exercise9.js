let Dog = new Pets("Sharko", "", 5, true, Person.firstName, false);
let Cat = new Pets("X", "", 3, false, Person.firstName, false);
let Mouse = new Pets("Y", "", 2, false, Person.firstName, true);
let People1 = new Person("Aleksandar", "Ivanovski", 26);
let People2 = new Person("Marko", "Markovski", 30);
let People3 = new Person("Dame", "Damjanoski", 20);



function Pets(name, type, age, isHealthy, owner, isAdopted){
    this.pName = name;
    this.pType = type;
    this.pAge = age;
    this.pIsHealthy = isHealthy;
    this.pOwner = owner;
    this.pIsAdopted = isAdopted;
}

function Person(firstName, lastName, age){
    this.eFirstName = firstName;
    this.eLastName = lastName;
    this.eAge = age;
}




let button = $("#button");
button.click(function(){
    
});