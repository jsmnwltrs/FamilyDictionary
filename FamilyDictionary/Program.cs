using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mistress", new Dictionary<string, string>() { { "name", "Tonya Roxanne" }, { "age", "28" }});
            myFamily.Add("doggo", new Dictionary<string, string>() { { "name", "Doofus" }, { "age", "4" } });

            foreach (var (member,info) in myFamily)
            { 
              Console.WriteLine($"{myFamily[member]["name"]} is my {member} and is {myFamily[member]["age"]} years old");
            }

            Console.ReadLine();

        }
    }
}
