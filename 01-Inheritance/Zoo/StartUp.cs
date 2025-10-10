﻿using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main()
        {
            Lizard lizard = new Lizard("Rex");
            Console.WriteLine(lizard.Name);

            Snake snake = new Snake("Slither");
            Console.WriteLine(snake.Name);
        }

        public class Animal
        {
            public Animal(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
        }

        public class Reptile : Animal
        {
            public Reptile(string name)
                :base(name)
            {
                   
            }
        }

        public class Mammal : Animal
        {
            public Mammal(string name)
                : base(name)
            {

            }
        }

        public class Lizard : Reptile
        {
            public Lizard(string name)
                :base(name)
            {
                
            }
        }

        public class Snake : Reptile
        {
            public Snake(string name)
                :base(name)
            {
                
            }
        }

        public class Gorilla : Mammal
        {
            public Gorilla(string name)
                :base(name)
            {
                
            }
        }

        public class Bear : Mammal
        {
            public Bear(string name)
                :base(name)
            {
                
            }
        }
    }
}