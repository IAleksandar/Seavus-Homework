let s = "";

for(var i = 1; i < 20; i ++) {
    if (i%2===0){
        console.log("\n" + i);
        i++;
    }
    else {
        console.log(" " + i);

        i++;
    }
  s += i + " ";
}
console.log(s);

