using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public string name;
        public int alter;
        public string beruf;


        public Person(string _name, int _alter, string _beruf)
        {
            name = _name;
            alter = _alter;
            beruf = _beruf;
        }

        public void Begruessung(string userName)
        {
            Console.WriteLine($"\nHallo {userName}.\nMein Name ist {name}. \n\nHier sind meine Daten:\n");
        }

        public void Infos()
        {
            Console.WriteLine($"Name: {name},\nAlter: {alter},\nBeruf: {beruf}");
        }
    }
}
