using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Citizen
    {
        public Citizen(string birthCountry,string fullname)
        {
            BirthCountry = birthCountry;
            FullName = fullname;

        }
        public const string Citizienship = "Azerbaijan";

        public readonly string FullName;
        public string BirthCountry { get; private set; }

        public void ChangeCountry(string cnt)
        {
            BirthCountry = cnt;
        }

    }
}
