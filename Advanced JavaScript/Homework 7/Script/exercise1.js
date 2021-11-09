function Person(firstName, lastName, age, id){
    this.id = id;
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.getFullName = function(){
        console.log(`${this.firstName} ${this.lastName}`);
    }
}

function Animal(name, age){
    this.name = name;
    this.age = age;
    this.eat = function(){
        console.log(`MMMMMM`);
    };
    this.sleep = function(){
        console.log(`GRRR`);
    }
}

function Cat(color, name, age, ownerId){
    Object.setPrototypeOf(this, new Animal(name, age));
    this.color = color;
    this.ownerId = ownerId;
    this.meow = function(){
        console.log(`The cat ${this.name} says Meow`);
    }
    this.printOwnerDetails = function(owner){
        if (this.ownerId == owner.id){
            console.log(`Owner: ${this.name}`);
            owner.getFullName();
        }
        if (this.ownerId != owner.id){
            console.log(`No owner`);
            return;
        }
    }   
}

function PersianCat(eyeColor, color, name, age, ownerId){
    Object.setPrototypeOf(this, new Cat(color, name, age, ownerId));
    this.eyeColor = eyeColor;
    this.furDescription = function(){
        console.log(`The cat ${this.name} has full fur!`);
    }
}

function RagDollCat(weight, isFriendly, color, name, age, ownerId){
    Object.setPrototypeOf(this, new Cat(color, name, age, ownerId));
    this.weight = weight;
    this.isFriendly = isFriendly;
    this.printPersonality = function(type){
        if(type === true){
            this.isFriendly = true;
            console.log(`This cat ${this.name} is friendly`);
        }
        else {
            this.isFriendly = false;
            console.log(`This cat ${this.name} is not friendly`);
        }
    }
}


let people = [new Person("Ana", "Anevska", 25, 1), new Person("Petar", "Petrovski", 20, 2), new Person("Mitre", "Mitrevski", 24, 3), 
              new Person("John", "Doe", 22, 4), new Person("Martin", "Martinoski", 20, 5)];

let colors = ["white", "black", "brown", "orange", "grey"];

let cat1 = new Cat(colors[0], "Stinky", 3, 2);
let cat2 = new Cat(colors[2], "Coco", 5, 4);
cat1.eat();
cat2.sleep();
let persianCat = new PersianCat("green", colors[3], "Bella", 5, 2);
let ragDollCat = new RagDollCat(15, true, colors[5], "Leo", 3, 4);
let ragDollCat2 = new RagDollCat(20, false, colors[1], "Lilly", 5, 6);
persianCat.meow();
cat1.printOwnerDetails(people[1]);
cat2.printOwnerDetails(people[3]);
persianCat.printOwnerDetails(people[1]);
ragDollCat.printOwnerDetails(people[3]);
persianCat.furDescription();
ragDollCat.printPersonality(ragDollCat.isFriendly);
ragDollCat2.printPersonality(ragDollCat2.isFriendly);
console.log(cat1);
console.log(cat2);
console.log(persianCat);
console.log(ragDollCat);
console.log(ragDollCat2);
