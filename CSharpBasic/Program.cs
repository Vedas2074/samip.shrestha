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
        }
    }
}
