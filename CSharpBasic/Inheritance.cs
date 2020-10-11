using System;
public abstract class Shape//abstruct means implementation on the own way under the class
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public void PrintDetails()
    {
        Console.WriteLine("printing details for shape...");

    }
}
public class Square : Shape
{
    public double Side { get; set; }
    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
}
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length * Breadth);
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => Math.PI * Radius;
}
//single inheritence
//multilevel inheritence
class A
{

}
class B : A
{

}
class C : B
{

}