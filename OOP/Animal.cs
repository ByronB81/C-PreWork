using System;
using System.Collections.Generic;

class Animal
{
    public string Name;
    public string Breed;
    public int Age;
    public bool Adopted;

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
        Animal pet1 = new Animal();
        pet1.Name = "Toby";
        pet1.Breed = "Golden Retriever";
        pet1.Age = 4;
        pet1.Adopted = false;

        Animal pet2 = new Animal();
        pet2.Name = "Boots";
        pet2.Breed = "Calico Cat";
        pet2.Age = 6;
        pet2.Adopted = false;

        Animal pet3 = new Animal();
        pet3.Name = "Harley";
        pet3.Breed = "Labrador Retriever";
        pet3.Age = 2;
        pet3.Adopted = false;

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
