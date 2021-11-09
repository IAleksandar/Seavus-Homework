array = [3, 5, 6, 8, 11, "a"];

function f(){
    let min = Infinity;
    let max = -Infinity;
    let sum = 0;

    for (let i = 0; i < array.length; i++) {
        if (array[i] < min){
            min = array[i];
        }
        if (array[i] > max) {
            max = array[i];
        }
        sum = min + max;
    }
        console.log(`Max: ${max}, Min: ${min}, Sum: ${sum}`);
}

f();