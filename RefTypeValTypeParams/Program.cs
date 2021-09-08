using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }
        //static void SendAPersonByValue(Person p)
        //{
        //    p.personAge = 99;
        //    p = new Person("Nikki", 99);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passing Person object by value");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();            
            SendAPersonByReference(ref fred);
            Console.WriteLine("\nAfter by reference call, Person is:");
            fred.Display();
            Console.WriteLine();
        }
        static void SendAPersonByValue(Person p)
        {
            p.personAge = 99;
            //p.personName = "Jack";
            p = new Person("Nikki", 99);
            //Если ссылочный тип передается по значению, то вызываемый код может изменять значения
            //данных состояния объекта, но не объект, на который указывает ссылка.
        }
        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikki", 999);
            //Если ссылочный тип передается по ссылке, тогда вызываемый код может изменять значения 
            //данных состояния объекта, а также объект, на который указывает ссылка.
        }
    }
}
