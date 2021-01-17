let grade1 = parseInt(prompt("Enter grade 1: "));
let grade2 = parseInt(prompt("Enter grade 2: "));
let grade3 = parseInt(prompt("Enter grade 3: "));
let grade4 = parseInt(prompt("Enter grade 4: "));
let grade5 = parseInt(prompt("Enter grade 5: "));

let average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

if(average < 8)
{
    alert("The student hasn't passed");
}

else {
    alert("The student passed");
}
