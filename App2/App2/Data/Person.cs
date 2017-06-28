using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Data
{
    public class Person
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{Name} {Title}";
        }

        public static List<Person> People =
        new List<Person>()
        {
            new Person(){ Name = "Test1", Title = "Detail1"},
            new Person(){ Name = "Test2", Title = "Detail2"},
            new Person(){ Name = "Test3", Title = "Detail3"},
            new Person(){ Name = "Test4", Title = "Detail4"},
            new Person(){ Name = "Test5", Title = "Detail5"},
            new Person(){ Name = "Test6", Title = "Detail6"},
        };

    }
}
