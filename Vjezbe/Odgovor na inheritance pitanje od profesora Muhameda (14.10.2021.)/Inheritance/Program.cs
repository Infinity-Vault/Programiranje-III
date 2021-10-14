using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { Name = "Some Name", Age = 22 };
            Console.WriteLine(p);

            Professor einstein = new Professor() { Name = "Albert Einstein", Age = 80, CurrentSemester = 3, NumberOfClasses = 7 };
            Console.WriteLine(einstein);

            Student student = new Student() { Name = "Some Student", Age = 21, CurrentYear = 2, IB = 200140 };
            Console.WriteLine(student);

            Console.ReadLine();
        }

        //Class Person:
        internal class Person
        {
            //Property name:
            public string Name { get; set; }

            //Property age:
            public int Age{get;set;}

            public  override  string ToString()
            {
                return $"Name: {Name}, age: {Age}";
            }

        }

        //Class Professor which extends class Person:
        internal class Professor : Person
        {
            //Property current semester:
            public int CurrentSemester{get;set;}

            //Property number of classes:
            public int NumberOfClasses { get; set; }

            //Override of the ToString() method enharited from class object:

            public override string ToString()
            {
                //Kod redefinisanja istoimene metode iz bazne klase se moze koristiti new (sto ce sakriti baznu metodu/nece biti pristupljiva) ili override (sto ce extendat tj. naslijediti baznu metodu i dodati nesto novo);
                return $"{base.ToString()},current semester: {CurrentSemester},number of classes: {NumberOfClasses}";
                //Or:
                //$"Name of the profesor: {base.Name},age: {base.Age}, current semester: {CurrentSemester},number of classes: {NumberOfClasses}";
            }
        }
        //Class Student extending class Person:
        internal class Student : Person
        {
            public int IB{get; set; }

            public int CurrentYear { get; set; }

            public override string ToString()
            {
                return $"{base.ToString()}, IB: {IB}, current year: {CurrentYear}";
            }
        }

    }
}
