let firstNames = ["Ana", "Aleksandar", "Viktor", "Maja", "Damjan"];
let lastNames = ["Anevska", "Ivanovski", "Stojanovski", "Trifunoska", "Damjanoski"];

(function(fNames, lNames) {
    var fullNames = [];
    fNames = firstNames;
    lNames = lastNames;
    for (var i=0; i<fNames.length; i++){
        fullNames.push(`${fNames[i]} ${lNames[i]}`);
    }
    console.log(fullNames); 

    return fullNames;
})(firstNames, lastNames);