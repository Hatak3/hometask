using Homework.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.MobilPhone
{
    public class FilterContact
    {
        List<Contact> contacts = new List<Contact>();
        public Contact DisplayByNumber(string number) { return contacts.Where(c => c.number == number).FirstOrDefault(); }
        public void AddNUmber(Contact contact) { contacts.Add(contact); }
        public void View()
        {
            if (contacts != null && contacts.Count != 0)
            {
                foreach (Contact item in contacts)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public List<Contact> FilterByName(string name) { return contacts.Where(c => c.name == name).ToList(); }


    }
}
