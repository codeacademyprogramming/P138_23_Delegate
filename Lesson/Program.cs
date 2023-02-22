using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;

            byte? age = null;

            byte price=34;

            int nameLength;

           

            //if(name == null)
            //    nameLength = 0;
            //else
            //    nameLength = name.Length;

            nameLength = name == null ? 0 : (name==" "?0:name.Length);

            string result = price < 10 ? "Ucuzdur" : "Bahadir";

            //string newName = name==null?"Hikmet":name;
            string newName = name ?? "Hikmet";


            Human human = new Human();

            var firstLetter = human.Name?.Substring(0, 1);

            int? newNameLength = human.Name?.Length;

            Console.WriteLine(firstLetter);

            Citizen ctz = new Citizen("Turkey","Hikmet Abbasov");
            Citizen ctz2 = new Citizen("Turkey", "Nermin Abbasova");




        }
    }
}
