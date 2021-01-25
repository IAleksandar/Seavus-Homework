let arrays = [NaN, 3, 2, 0, undefined, "sedc", true, false];

function Falsy(array){
    let arr = array;
    for(let i=0; i<array.length; i++){
        if(!!arr[i]){
            arr.splice(i,1);
        }
        else {
            i++;
        }
    }

}

Falsy(arrays);
console.log(arrays);