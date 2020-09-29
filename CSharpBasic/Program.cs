using System;
using AccessModifierAndMethods;
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
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.DoSomething();
            Person person = new Person();
            person.name = "Bishnu";
            person.Age = 17;
            var x = person.Age;
            var y = person.Address;
        }
    }
}
