using System;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Person person;

                // If age ≤ 15 → create Child, else Person
                if (age <= 15)
                    person = new Child(name, age);
                else
                    person = new Person(name, age);

                Console.WriteLine(person);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public class Person
        {
            private string name;
            private int age;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name 
            { get => name;
                private set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Name cannot be empty");
                    }
                    name = value;
                }
            }
            public int Age 
            {
                get => age; 
                protected set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Age must be positive!");
                    }
                    age = value;
                }
            }

            public override string ToString()
                => $"Person -> Name: {Name}, Age: {Age}";
        }
        public class Child : Person
        {
            public Child(string name, int age)
                : base (name, age)
            {
                
            }
            public override string ToString()
                => $"Child -> Name: {Name}, Age: {Age}";
        }
    }
}