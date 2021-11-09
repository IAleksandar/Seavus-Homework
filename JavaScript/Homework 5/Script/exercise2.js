arr = [2, 4, 5];


function print(item, niza){
    let sum = 0;
    for (item of niza){
        console.log(item);
        sum+=item;
    }
    console.log(sum);
    console.log(niza[0] + ` + ` + niza[1] + ` + ` + niza[2] + ` = ` + sum);
}

print(arr, arr);



// -----------------  kako mozam na mestoto od niza[0], niza[1], niza[2], da bide item, bidejki ako stavam item samo 5ka mi pokazuva... -------- //