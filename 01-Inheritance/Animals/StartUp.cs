using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();

            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                    break;

                string details = Console.ReadLine();

                try
                {
                    if (string.IsNullOrWhiteSpace(details))
                        throw new ArgumentException("Invalid input!");

                    string[] parts = details.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    Animal animal = type switch
                    {
                        "Dog" or "Frog" or "Cat" when parts.Length == 3 =>
                            CreateThreeToken(type, parts),

                        "Kitten" or "Tomcat" when parts.Length == 3 =>
                            CreateThreeToken(type, parts), // gender ignored in ctor

                        _ => throw new ArgumentException("Invalid input!")
                    };

                    animals.Add(animal);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            foreach (var a in animals)
                Console.WriteLine(a);
        }

        private static Animal CreateThreeToken(string type, string[] parts)
        {
            string name = parts[0];
            if (!int.TryParse(parts[1], out int age))
                throw new ArgumentException("Invalid input!");
            string gender = parts[2];

            return type switch
            {
                "Dog" => new Dog(name, age, gender),
                "Frog" => new Frog(name, age, gender),
                "Cat" => new Cat(name, age, gender),
                "Kitten" => new Kitten(name, age, gender), // ctor forces Female
                "Tomcat" => new Tomcat(name, age, gender), // ctor forces Male
                _ => throw new ArgumentException("Invalid input!")
            };
        }
    }

    public abstract class Animal
    {
        public Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid input!");
            }
            if (age <= 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            if (string.IsNullOrWhiteSpace(gender) || (gender != "Male" && gender != "Female"))
            {
                throw new ArgumentException("Invalid input!");
            }

            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public abstract string ProduceSound();
        public override string ToString()
        {
            var nl = Environment.NewLine;
            return $"{GetType().Name}{nl}{Name} {Age} {Gender}{nl}{ProduceSound()}";
        }
    }

    public class Dog
        : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override string ProduceSound() => "Woof!";
    }
    public class Frog
        : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override string ProduceSound() => "Ribbit";
    }
    public class Cat
        : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {

        }
        public override string ProduceSound() => "Meow meow";
    }
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string _)
            : base(name, age, "Female")
        {
        }

        public override string ProduceSound() => "Meow";
    }

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string _)
            : base(name, age, "Male")
        {
        }

        public override string ProduceSound() => "MEOW";
    }
}
