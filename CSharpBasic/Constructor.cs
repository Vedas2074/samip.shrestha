namespace LearningClasses
{
    internal class Person
    {
        // Default parameterless contructor
        public Person()
        {
            
        }

        // parametrized constructor
        public Person(string n, string add)
        {
            this.Name = n;
            this.Address = add;
        }

        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
            this.Age = a;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public byte Age { get; set; }

        public static string Scientificname = "Homo Sapiens";

        public static void Do()
        {
            
        }
    }
}