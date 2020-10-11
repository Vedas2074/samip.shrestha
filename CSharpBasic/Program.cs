using System;
using AccessModifierAndMethods;
using LearningClasses;
namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();
            //Console.Write("Hi," + name);
            //SelectionStatement selectionStatement = new SelectionStatement();
            //selectionStatement.LearnIfElse();
            //selectionStatement.LearnSwitchCases();      
            //AccessModifier accessModifier = new AccessModifier();
            //accessModifier.DoSomething();
            //Person person = new Person();
            //person.name = "Bishnu";
            //person.Age = 17;
            //var x = person.Age;
            //var y = person.Address;
            var person1 = new Person();
            person1.Name = "Samip";
            person1.Address = "Lalitpur";
            person1.Age = 21;

            var person2 = new Person("Samip", "Ktm",23);
            var x = Person.Scientificname;
            Person.Do();
            var y = Math.Sqrt(5); 
            var z = Calculator.Sum(21,25);
            var s = Calculator.Sum<int>(21,25);
            var s1 = Calculator.Sum<decimal>(21.56545m,25.565m);
             Rectangle rectangle = new Rectangle();
        rectangle.Length = 23.6;
        rectangle.Breadth = 6.32;
        var result = rectangle.GetArea();


        }
    }
}
