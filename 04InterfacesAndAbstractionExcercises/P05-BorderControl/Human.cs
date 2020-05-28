using System;
using System.Collections.Generic;
using System.Text;

namespace P05_BorderControl
{
    public class Human : ILivable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public Human(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}
