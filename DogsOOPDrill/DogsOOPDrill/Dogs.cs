using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsOOPDrill
{
    public class Dogs
    {
        // Propertes
        private Dog[] dogsArray = new Dog[50];
        private List<Dog> listOfDogs = new List<Dog>();

        // Construcors
        // Base constructor
        public Dogs(Dog[] dogs)
        {
            this.dogsArray = dogs;
        }

        // Copy construcor
        public Dogs(Dogs dogsTag)
        {
            this.dogsArray = dogsTag.dogsArray;
        }

        // Function that desribe the dogs.
        public override string ToString()
        {
            string st = "";
            st = "Dogs" + '\n';
            for (int i = 0; i < dogsArray.Length; i++)
            {
                st += dogsArray[i].ToString();
            }
            return st;
        }

        // Method that add to the list a dog.
        public void AddToList(Dog dog)
        {
            listOfDogs.Add(dog);
        }

        public string DesribeRaceDogs()
        {
            string st = "";
            for (int i = 0; i < listOfDogs.Count(); i++)
            { 
                if (listOfDogs[i].GetType().Equals(
                st = 
            }
            return st;
        }
    }
}
