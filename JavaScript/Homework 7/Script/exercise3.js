let button = document.getElementById("button");

button.addEventListener("click", function(){
    let fName = document.getElementById("first").value;
    let lName = document.getElementById("last").value;
    let a = document.getElementById("age").value;
    let student = new Object();
    student.firstName = fName;
    student.lastName = lName;
    student.age = a;
    let students = [student.firstName, student.lastName, student.age];
    console.log(students);    
});