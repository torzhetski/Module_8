using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Task_4;
using static System.Console;
class Program
{
    static void Main()
    {
        if (!(File.Exists("BookOfContacts.xml")))
            using (File.Create("BookOfContacts.xml")) ;

        XElement myPerson = new XElement("Person");
        XElement myAddress = new XElement("Address");
        XElement myStreet = new XElement("myStreet");
        XElement myHouseNumber = new XElement("HouseNumber");
        XElement myFlatNumber = new XElement("FlatNumber");
        XElement myPhones = new XElement("Phones");
        XElement myMobilePhone = new XElement("Phone");
        XElement myFlatPhone = new XElement("FlatPhone");
        while (true)
        {
            WriteLine("\nPress:\n1 - to add new contect\n2 - to show all book\n0 - to exit");
            ConsoleKeyInfo key = ReadKey();
            switch (key.KeyChar)
            {
                case '1':
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
                    XAttribute xAttributeName = new XAttribute("name", Contact.FIO);
                    myStreet.Add(Contact.Street);
                    myHouseNumber.Add(Contact.HouseNumber);
                    myFlatNumber.Add(Contact.FlatNumber);
                    myAddress.Add(myStreet, myHouseNumber, myFlatNumber);
                    myMobilePhone.Add(Contact.MobilePhone);
                    myFlatPhone.Add(Contact.FlatPhone);
                    myPhones.Add(myMobilePhone, myFlatPhone);
                    myPerson.Add(myAddress, myPhones, xAttributeName);
                    using (StreamWriter sw = new StreamWriter("BookOfContacts.xml", true))
                    {
                        sw.WriteLine(myPerson.ToString());
                    }
                    myStreet.RemoveAll();
                    myHouseNumber.RemoveAll();
                    myFlatNumber.RemoveAll();
                    myAddress.RemoveAll();
                    myMobilePhone.RemoveAll();
                    myFlatPhone.RemoveAll();
                    myPhones.RemoveAll();
                    myPerson.RemoveAll(); 
                    break;
                case '2':
                    Clear();
                    WriteLine(File.ReadAllText("BookOfContacts.xml"));
                    break;
                case '0':
                    return;
                    break;
                default:
                    WriteLine("Undefined char");
                    break;
            }
        }

    }
}
