using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsOOPDrill
{
    public class Dog
    {
        // Properties
        private int id;
        private string name;
        private string type;
        private int birthYear;
        private string gender;
        private double weight;
 

        // Constructors
        // Base construcor
        public Dog(int id, string name, string type, int birthYear, string gender, double weight)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.birthYear = birthYear;
            this.gender = gender;
            this.weight = weight;
        }

        // Copy constructor
        public Dog(Dog d1)
        {
            this.id = d1.id;
            this.name = d1.name;
            this.type = d1.type;
            this.birthYear = d1.birthYear;
            this.gender = d1.gender;
            this.weight = d1.weight;
        }

        // Set dog's details method
        public void SetDog()
        {
            Console.WriteLine("Please enter the dog's id: ");
            this.id = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the name: ");
            this.name = Console.ReadLine();

            Console.WriteLine("Please enter the type: ");
            this.type = Console.ReadLine();

            Console.WriteLine("Please enter the birth year of the dog: ");
            this.birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the gender: ");
            this.gender = Console.ReadLine();

            Console.WriteLine("Please enter the weight: ");
            this.weight = int.Parse(Console.ReadLine());
        }

        // To string method, with override the base ToString function.
        public override string ToString()
        {
            return "Dog with id: " + id + "name: " + name + "type: " + type + "birth year: " + birthYear + ",gender: " + gender + ", weight: " + weight;
        }

        // Set weight method
        public void SetDogWeight(double weight)
        {
            this.weight = weight;
        }

        public bool CheckMatch(Dog d1)
        {
            double calc = d1.weight - this.weight;
            calc = Math.Abs(calc);
            if ((this.type.Equals(d1.type)) && (this.gender.Equals("Male") && (d1.gender.Equals("Femle")) && (calc < 2)))
            {
                return true;
            }
            return false;
        }

        // Method that return the age of the dog.
        public int Age(int currentYear)
        {
            return currentYear - this.birthYear;
        }

        // Getters
        public string GetType()
        {
            return this.type;
        }

        public string GetGender()
        {
            return this.gender;
        }

        // Create gur for parents
        public Dog Check(Dog fatherDog, int counterDogs, int currentYear)
        {
            string name = "";
            name = (this.name[0] + this.name[1] + fatherDog.name[0] + fatherDog.name[1] + fatherDog.name[2]).ToString();
            double GurWeight = this.weight * 0.1;
            Dog d2 = new Dog(555, name, this.type, currentYear, this.gender, weight);
            return d2;
        }


    }
}
