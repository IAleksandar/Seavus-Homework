using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary2.Classes
{
    public static class PetStore<T> where T : Pet
    {
        public static List<T> Pets { get; set; }
        static PetStore()
        {
            Pets = new List<T>();
        }
        public static void PrintsPets()
        {
            foreach(T pet in Pets)
            {
                Console.WriteLine(pet.Name);
            }

        }
        public static void BuyPet(T pet)
        {
            T existingPet = Pets.FirstOrDefault(x => x.Name == pet.Name);
            if(existingPet == null)
            {
                Console.WriteLine("There is no pet with that name");
            }
            else
            {
                Pets.Remove(pet);
                Console.WriteLine($"The pet with name {pet.Name} has been successfully removed!");
            }
        }
    }
}
