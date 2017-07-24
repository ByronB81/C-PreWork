using System;
using System.Collections.Generic;

class Contact
{
    public string Name;
    public string Phone;
    public string Address;
}

class Program
{
    public static void Main()
    {
        Contact hendrix = new Contact();
        hendrix.Name = "Jimi Hendrix";
        hendrix.Phone = "503-652-1584";
        hendrix.Address = "208 NE Hoyt St, Portland, OR, 97232";

        Contact elvis = new Contact();
        elvis.Name = "Elvis Presley";
        elvis.Phone = "598-445-1512";
        elvis.Address = "51 Nightengale Ln, Texarkana, TX, 98745";

        Contact einstein = new Contact();
        einstein.Name = "Albert Einstein";
        einstein.Phone = "454-756-8541";
        einstein.Address = "156 Huntington Dr, Seattle, WA, 48795";

        List<Contact> AddressBook = new List<Contact>() {hendrix, elvis, einstein};
        foreach (Contact person in AddressBook)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Phone: " + person.Phone);
            Console.WriteLine("Address: " + person.Address);
        }

    }

}
