using System;
using System.Collections.Generic;
using System.Text;

namespace P06_BirthdayCelebrations
{
    public class Human : ILivable, IBirthable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public Human(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
