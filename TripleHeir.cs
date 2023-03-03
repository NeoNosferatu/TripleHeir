using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleHeir
{
    class TripleHeir
    {
        static void Main(string[] args)
        {
            Char number = new Char();
            String name = new String();
            Int age = new Int();
            number.number();
            name.name();
            age.age();
            Console.ReadLine();
        }
    }
    public class Char
    {
        public char Number;
        public Char()
        {
            Number = '1';
        }
        public void number()
        {
            Console.WriteLine($"Номер: {Number}");
        }
    }
    public class String : Char
    {
        public string Name;
        public String()
        {
            Name = "Maks";
        }
        public void name()
        {
            Console.WriteLine($"Имя: {Name}");
        }
    }
    public class Int : String
    {
        public int Age;
        public Int()
        {
            Age = 20;
        }
        public void age()
        {
            Console.WriteLine($"Возраст: {Age}");
        }
    }
}

