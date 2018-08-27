using System;
using System.Collections.Generic;

namespace familydictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("wife", new Dictionary<string, string>() {
                {"name", "Melia"},
                {"age", "30"},
            });

            myFamily.Add("sister", new Dictionary<string, string>() {
                {"name", "Mindy"},
                {"age", "37"},
            });

            myFamily.Add("mom", new Dictionary<string, string>() {
                {"name", "Colleen"},
                {"age", "65"},
            });

            myFamily.Add("dad", new Dictionary<string, string>() {
                {"name", "Bob"},
                {"age", "63"},
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                // Console.WriteLine($"memberKey {member.Key}");
                // foreach (KeyValuePair<string, string> person in member.Value)
                // {
                // Console.WriteLine($"personKey {person.Key}");
                // Console.WriteLine($"personValue {person.Value}");
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
                // }
            }
        }
    }
}
