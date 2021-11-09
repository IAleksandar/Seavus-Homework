function factorial(x){
     if(x === 0){
        console.log("Input is 0");
         return 0;
     }
     console.log(`${x}`);
     return x + factorial(x-1);
 }
 
 factorial(3);