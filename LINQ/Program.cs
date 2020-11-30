using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ --Language INtegrated Query
            int[] numbers = {23,24,25,11,16,45};
            //Find all element from numbers array which are less than 75 and greater than 20
            //Using method syntax -lambda expression
            var result =numbers.Select(x => x < 75 && x > 20);//lamda expression
            var result1 =numbers.Where(x => x < 75 && x > 20);//lamda expression

            //Querysyntax -query expression
            var result2 = from x in numbers
                        where x < 75 && x > 20
                        select x;

            string[] names = {"Bishnu","Samip","Sanam","Rupesh","Suman","Biman"};
            //find name that start with 's' and having length less than 6
            var result3 = from name in names
                          where name.StartsWith("S")&& name.Length < 6
                          select name;
            //Projection
            var result4= from num in numbers
                         select num*num;

            //Ordering
            var result5= from num in numbers
                        orderby num
                        select num;

        //Partitioning
        var result6 =numbers.Take(5);
                    numbers.Skip(5).Take(5);

        //Quantifiers
        var IsEvenThere = numbers.Any(num => num % 2 ==0);
        var areAllEvens = numbers.All(numbers=>numbers%2==0);
        var is26there= numbers.Contains(26);
        var result8 = Enumerable.Range(1,100);
        var result9 = Enumerable.Repeat("Hello",10);

        List<Person> people = new List<Person>()
        {
            new Person() { Id=1, FirstName="Samip", LastName="Shrestha",Address="ktm",Age=1},
            new Person() { Id=2, FirstName="A", LastName="Shrestha",Address="ltp",Age=50},
            new Person() { Id=3, FirstName="B", LastName="Rawal",Address="bkt",Age=25},
            new Person() { Id=4, FirstName="C", LastName="Sanjel",Address="ktm",Age=10},
            new Person() { Id=5, FirstName="D", LastName="Kumal",Address="pok",Age=20},
        };
        // find all the people who live in ktm

        var result10= from person in people
                    where person.Address =="ktm"
                    select person;

        //Find all the people who are minor
        var result15=from person in people
                    where person.Age >18
                    select person;

        var result12=from person in people
                    where person.Age <18 && person.Address=="ktm"
                    select person;
        }
    }
}
