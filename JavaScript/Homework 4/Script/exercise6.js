let firstName = ["Bob", "Jill"];
let lastName = ["Georgy", "Wurtz"];
let newArray = [];

// ----------- Pomos za so ciklus kako bi mozel da ja ispecatam ako moze resenie ------ ///
/* function student (firstName, lastName){
    for (let i = 0; i < firstName.length; i++){
      newArray.push(firstName[i]);
      newArray.push(lastName[i]);

      return newArray;


    } 
    
    console.log(newArray);

}


student(firstName, lastName);


*/

function students (firstName, lastName){
  newArray.push(firstName[0]);
  newArray.push(lastName[0]);
  newArray.push(firstName[1]);
  newArray.push(lastName[1]);
  console.log(`1. ` + newArray[0] + ` ` + newArray[1] + ` ` + `2. ` + newArray[2] + ` ` + newArray[3]);
}

students(firstName, lastName);