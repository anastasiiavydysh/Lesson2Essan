using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class User
    {
        readonly string name;
        readonly string surname;
        readonly string login;
        readonly int age;
        readonly DateTime date;

        public User(string name, string surname, string login, int age, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.age = age;
            this.date = date;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name + ", surname: " + surname + ", login: " + login + ", age: " + age + ", date: " + date.Date);
        }
    }
}
