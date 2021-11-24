using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class Animals
    {
        string name;
        public Animals(string name)
        {
            this.name = name;    
        }

        public void NamudiHayvon(string name)
        {
            Console.WriteLine($"Hayvoni khonagi {name}");
        }

        public (int Age, string Name) Hayvon(int age, string name)
        {
            return (age, name);
        } 
    }
}
