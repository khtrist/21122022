using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _21122022
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public string GetFullname()
        {
            return Name + " " + Surname;
        }
        public Human(string name ,string surname , int age)
        {
            Name= name;
            Surname= surname;
            Age= age;
        }
        

        
    }
}
