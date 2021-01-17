let n1 = parseInt(prompt("Input1: "));
let n2 = parseInt(prompt("Input2: "));

function compare(){
    let n3 = 100;
    if (n1 > n3){
        console.log(n1 + " is above 100");
    }

    if(n2 > n3){
        console.log(n2 + " is above 100");
    }
    if(n1 < n2){
        console.log(n2 + " is closer to 100");
    }
    else{
        console.log(n1 + " is closer to 100");
    }
}

compare();