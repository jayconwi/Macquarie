using System;
using System.Collections.Generic;

namespace MacquarieCodingChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> {
                new Cow(),
                new Duck(),
                new Bird()
            };
            animals.ForEach(delegate (Animal a) {
                a.PrintProperties();
            });
        }
    }

    public class Animal
    {
        public string Type { get; set; }
        public string Mobility { get; set; }
        public string Food { get; set; }
        public int LegCount { get; set; }

        public Animal()
        {
            Type = this.GetType().Name;
            Mobility = "walking";
            Food = "grass"; // By default these animals can eat grass.
            LegCount = 2;
        }

        public virtual void PrintProperties()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Has {LegCount} legs.");
            Console.WriteLine($"Moves by {Mobility}.");
            Console.WriteLine($"Eats {Food}.\r\n");
        }
    }

    public class Cow : Animal
    {
        public Cow()
        {
            Type = this.GetType().Name;
            Mobility = "walking";
            Food = "grass";
            LegCount = 4;
        }
    }

    public class Duck : Animal
    {
        public Duck()
        {
            Type = this.GetType().Name;
            Mobility = "swimming";
            Food = "different kinds of food such as corn";
            LegCount = 2;
        }
    }

    public class Bird : Animal
    {
        public Bird()
        {
            Type = this.GetType().Name;
            Mobility = "flying";
            Food = "bird seed";
            LegCount = 2;
        }
    }

}
