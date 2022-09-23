using Homework.MobilPhone;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Phone
{
    public class Phone
    {
        private static FilterContact contac = new FilterContact();
        public static void Main(string[] args)
        {
            SeeDatabase();
            Console.WriteLine("Look at Menu below and choose operation");
            Console.WriteLine("1 - Display by Number");
            Console.WriteLine("2 - Add Contact");
            Console.WriteLine("3 - Find by Name");
            Console.WriteLine("4 - View all Contacts");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("Please add number");
                    string b = Console.ReadLine();
                    Console.WriteLine(contac.DisplayByNumber(b).ToString());
                    break;
                case 2:
                    Contact newContact = CreateContact();
                    contac.AddNUmber(newContact);
                    break;
                case 3:
                    Console.WriteLine("Please add name");
                    string name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 4:
                    Console.WriteLine("All contact see");
                    contac.View();
                    break;
                    break;
                default:
                    break;
            }
        }
        public static void SeeDatabase()
        {
            var cont = new Contact("Ruslan", "555-55-88");
            var cont1 = new Contact("Kamran", "555-54-88");
            var cont2 = new Contact("Ali", "555-53-88");
            var cont3 = new Contact("Fidan", "555-52-88");

            contac.AddNUmber(cont);
            contac.AddNUmber(cont1);
            contac.AddNUmber(cont2);
            contac.AddNUmber(cont3);
        }
        public static void SearchByName(string name)
        {
            List<Contact> con = contac.FilterByName(name);
            foreach (Contact contact in con)
            {
                Console.WriteLine(contac.ToString());
            }
        }
        public static Contact CreateContact()
        {
            Console.Write("Name of the contact ");
            string name = Console.ReadLine().Trim();
            Console.Write("Number of the contact");
            string number = Console.ReadLine();
            Contact contact = new Contact(name, number);
            return contact;
        }
    }
}
