using ModelCodeFirst_L1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCodeFirst_L1
{
    class Program
    {
        public static void AddPerson(LabDbContext _ctx, string name, string middleName, string lastName, string telephoneNumber)
        {
            Person person = new Person();
            person.FirstName = name;
            person.LastName = lastName;
            person.MiddleName = middleName;
            person.TelephoneNumeber = telephoneNumber;

            _ctx.Persons.Add(person);
            _ctx.SaveChanges();
        }

        public static void ShowPersons(LabDbContext _ctx)
        {
            foreach(Person p in _ctx.Persons.ToList())
            {
                Console.WriteLine("First Name : " + p.FirstName + " " + "Last Name : " + p.LastName);
            }
        }
        static void Main(string[] args)
        {
            var _ctx = new LabDbContext();
            AddPerson(_ctx, "Acsinte", "Matei", "Ionut", "0746794520");
            AddPerson(_ctx, "Savu", "Tudor", "Ilie", "0757191402");
            ShowPersons(_ctx);
        }
    }
}
