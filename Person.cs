using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Person
    {
        private string _name;
        private int _age;
        

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get { return _name;} }
        public int Age { get { return _age; } }


    }
}
