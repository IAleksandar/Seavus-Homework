
let array = [];


function createArray(arr){
    // let counter = 6;
    let niza = [];
    niza = [arr[0]];
    for (let i = 1; i < arr.length; i++){
        // debugger;
        if(isNaN(arr[i])){
            // debugger;
            console.log("The input is not a number");
            return;
        }
        if((arr[i-1]%2 === 0 && arr[i]%2 === 0)){
            niza.push(`-`, arr[i]);
        }
        else {
            niza.push(arr[i]);
        }
    }
    console.log(niza);
}

createArray([2,5,4,4,1,0]);
createArray([1,2,4,4,1,0]);