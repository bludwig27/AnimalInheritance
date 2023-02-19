using System;

namespace AnimalInheritance
{
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class Echidna : Animal
    {
        public string food;
        protected string biome;
        public string weight;

        public void setBiome(string biome)
        {
            this.biome = biome;
        }
        public virtual string getBiome()
        {
            return biome;
        }

        public override string getName()
        {
            return base.getName();
        }

        public override string getType()
        {
            return type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal();
            myPet.setName("Sparky");
            myPet.setType("Dog");
            myPet.color = "white";

            Console.WriteLine();
            Console.WriteLine("Animal Information");
            Console.WriteLine($"Name = {myPet.getName()}");
            Console.WriteLine($"Type = {myPet.getType()}");
            Console.WriteLine($"Color = {myPet.color}");

            Echidna myEchidna = new Echidna();
            myEchidna.setName("Iggy");
            myEchidna.setType("short-beaked echidna");
            myEchidna.color = "brown";
            myEchidna.food = "termites";
            myEchidna.setBiome("woodlands");
            myEchidna.weight = "11 pounds";

            Console.WriteLine();
            Console.WriteLine("Echidna Information");
            Console.WriteLine($"Name = {myEchidna.getName()}");
            Console.WriteLine($"Type = {myEchidna.getType()}");
            Console.WriteLine($"Color = {myEchidna.color}");
            Console.WriteLine($"Food = {myEchidna.food}");
            Console.WriteLine($"Habitat = {myEchidna.getBiome()}");
            Console.WriteLine($"Weight = {myEchidna.weight}");
        }
    }
}