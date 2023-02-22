using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public string GroupNo;

        public sealed override void Show()
        {
            Console.WriteLine($"{Name} {Surname} - {GroupNo}");
        }
    }
}
