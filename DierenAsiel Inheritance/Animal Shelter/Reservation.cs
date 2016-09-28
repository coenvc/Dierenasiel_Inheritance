using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Shelter.Animals;

namespace Animal_Shelter
{
    public class Reservation
    {
        //public Cat Cat { get; private set; }
        //public Dog Dog { get; private set; }

        public List<Animal> Animals = new List<Animal>();
        
        public void NewCat(string name, Gender gender, string badHabits)
        {
            Cat cat = new Cat(name, gender, badHabits);
            Animals.Add(cat);
        }
        
        public void NewDog(string name, Gender gender)
        {
            Dog dog = new Dog(name, gender);
            Animals.Add(dog);
        }


    }
}
