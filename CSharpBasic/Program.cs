using LearningClasses;
using System;

class Program
{
    static void Main()
    {       
        // var person1 = new Person("Bishnu", "Ktm");
        // var person2 = new Person("Ramesh", "Bhaktapur", 23);
        // var person3 = new Person("Rame", "Bhaktapur", 20);

        // var person4 = new Person();

        // // Accessing static members
        // var x = Person.ScientificName;
        // Person.Do();
        // var y = Math.Sqrt(342);

        // var s1 = Calculator.Sum<int>(23, 34);
        // var s2 = Calculator.Sum<decimal>(233443.23m, 34344656.1m);

                
        // Inheritance examples
        var r = new Rectangle(23.6, 6.32);
        var r1 = new Rectangle(278.6, 61.32);
        r.PrintDetails();
        r1.PrintDetails();
        r1.GetDiagoalLength();

        Shape s = new Square(34.5);        
        s.PrintDetails();

        Shape c = new Circle(23.4);
        c.PrintDetails();
    }
}