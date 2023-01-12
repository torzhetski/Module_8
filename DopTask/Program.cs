using System;
using Task_4;
using System.Collections.Generic;
using System.Xml.Linq;
using static System.Console;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        if (!(File.Exists("Contacts.json")))
            using (File.Create("Contacts.json")) ;
        

        WriteLine("\nEnter FIO of person");
        Contact.FIO = ReadLine();
        WriteLine("Enter Street of person");
        Contact.Street = ReadLine();
        WriteLine("Enter Mobile Phone of person");
        Contact.MobilePhone = ReadLine();
        WriteLine("Enter Flat Phone of person");
        Contact.FlatPhone = ReadLine();
        WriteLine("Enter House Number of person");
        Contact.HouseNumber = Convert.ToInt32(ReadLine());
        WriteLine("Enter Flat Number of person");
        Contact.FlatNumber = Convert.ToInt32(ReadLine());
        JObject person = new JObject(); 
        JObject phones= new JObject();
        JObject address= new JObject();
        address["FIO"] = Contact.FIO;
        address["Street"] = Contact.Street;
        address["House Number"] = Contact.HouseNumber;
        address["Flat Number"] = Contact.FlatNumber;
        phones["Mobile Phone"] = Contact.MobilePhone;
        phones["Flat Phone"] = Contact.FlatPhone;
        person["address"] = address;
        person["phones"] = phones;
        string json = JsonConvert.SerializeObject(person);
        File.WriteAllText("Contacts.json", json);
    }
}