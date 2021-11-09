let grade = prompt("Enter grade: ");

switch(grade) {
    case 'A':
        console.log("Excellent job!");
        break;
    case 'B':
        console.log("Good job!");
        break;
    case 'C':
        console.log("Passed");
        break;
    case 'D':
        console.log("Not so good!");
        break;
    case 'F':
        console.log("Failed!");
        break;
    default:
        console.log("Unkown grade!");
        break;
}