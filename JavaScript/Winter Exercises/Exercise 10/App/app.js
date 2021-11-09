let letter = prompt("Enter letter: ");

function check(){
    if (letter === 'a' || letter ==='e' || letter === 'i' || letter ==='o' || letter === 'u'){
        console.log(`Hit ${letter} Hit`);
    }
    else {
        console.log(letter);
    }
}

check();