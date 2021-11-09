using ClassLibrary2.Classes;
using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PetStore<Pet>.Pets.Add(new Dog("Stinky", "Bulldog", 3, "Steak"));
            PetStore<Pet>.Pets.Add(new Dog("Rex", "German Shepherd", 5, "Dog meal"));

            PetStore<Pet>.Pets.Add(new Cat("Bella", "Persian Cat", 1, true, 8));
            PetStore<Pet>.Pets.Add(new Cat("Kitty", "Ragdoll", 2, false, 7));

            PetStore<Pet>.Pets.Add(new Fish("Gray Triggerfish", "Goldfish", 1, "gold", 1.5));
            PetStore<Pet>.Pets.Add(new Fish("King Mackerel", "Guppy", 1, "grey", 1.2));

            PetStore<Pet>.PrintsPets();

            Console.WriteLine("============================");

            PetStore<Pet>.BuyPet(PetStore<Pet>.Pets[1]);
            PetStore<Pet>.BuyPet(PetStore<Pet>.Pets[2]);

            PetStore<Pet>.PrintsPets();


            Console.ReadLine();
        }
    }
}
