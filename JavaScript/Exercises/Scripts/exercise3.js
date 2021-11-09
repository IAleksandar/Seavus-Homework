arr = [1,2,3,4,5,6,7,8,9,10,"a"];

function check(array){
    let a = array;
    let odd = [];
    let even = [];
    for (let i=0; i<a.length; i++){
        if (isNaN(a[i])){
            console.log("The item is not a number");
        }
        else {
            if(a[i]%2==0){
                even.push(a[i]);
            }
            else {
                odd.push(a[i]);
            }
        }
    }
    console.log(odd);
    console.log(even);
}

check(arr);