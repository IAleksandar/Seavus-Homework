let animal = {
    name: prompt("Enter the name of the animal:"),
    kind: prompt("Is the animal kind ? "),
    speak: function(message){

        return  console.log(`${this.name} says: hey bro!!!`);
    }

}

animal.speak();
