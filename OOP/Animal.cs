using System;
using System.Collections.Generic;

class Animal
{
    public string Name;
    public string Breed;
    public int Age;
    public bool Adopted;

    public Animal(string petName, string petBreed, int petAge, bool petAdopted = false)
    {
        Name = petName;
        Breed = petBreed;
        Age = petAge;
        Adopted = petAdopted;
    }

    public bool IsACat()
    {
        if (Breed.Contains("Cat"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Adoptable()
    {
        if (Adopted == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Animal pet1 = new Animal("Toby", "Golden Retriever", 4);
        Animal pet2 = new Animal("Boots", "Calico Cat", 6);
        Animal pet3 = new Animal("Harley", "Labrador", 2);

        List<Animal> petList = new List<Animal>() {pet1, pet2, pet3};

        pet3.Name = "Harley the Great!";
        Console.WriteLine("Here are all of our pets: ");

        foreach (Animal pet in petList)
        {
            if (pet.Adoptable())
            {
                Console.WriteLine(pet.Name);
            }
        }

        Console.WriteLine("This pet best fits your search: ");
        foreach (Animal pet in petList)
        {
            if (pet.Age > 3 && !pet.IsACat())
            {
                Console.WriteLine(pet.Name + " the " + pet.Breed);
            }
        }

    }
}
