let girls = parseInt(prompt("Enter girls: "));
let boys = parseInt(prompt("Enter boys: "));
function team(girl,boy){
    let g = girls;
    let b = boys;
    if(g < 10){
        console.log("There are 0" + g + " girls");
    }
    if (b < 10) {
        console.log("There are 0" + b + " boys");
    }
    console.log(g + " girls " + b + " boys.");
}

team();