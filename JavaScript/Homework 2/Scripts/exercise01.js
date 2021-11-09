var max=0;
for (var i=0; i<5; i++) {
    var a = prompt("Enter a number: ");
    if (a>=max) {
        max=a;
    }

    else {
        console.log("Sleden");
        }
}

alert(`${max} e maksimumot`);