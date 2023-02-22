using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    partial class  Human
    {

        public Human()
        {

        }
        public Human(string name)
        {
            this.Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }
    }
    partial class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }
    partial class Human
    {
        public virtual void Show()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }

   
}
