using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace ZooPS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Salmon());
                fishZoo.AddAnimal(new Salmon());
                Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
            }
        }
    }

    public class Animal
    {
        
    }

    public class Mammal : Animal
    {
        
    }

    public class Bear : Mammal
    {
        
    }

    public class Donkey : Mammal
    {
        
    }

    public class Lion : Mammal
    {
        
    }

    public class Fish : Animal
    {
        
    }

    public class Salmon : Fish
    {
        
    }

    public class Clownfish : Fish
    {
        
    }

    public class Student
    {
        
    }

    public class Zoo<TAnimal> where TAnimal : Animal
    {
        // private TAnimal[] animalZooArr = Array.Empty<TAnimal>();
        List<TAnimal> animals = new List<TAnimal>();
        
        public void AddAnimal(TAnimal animal)  
        {
            animals.Add(animal);

            
            
            // Array.Resize(ref animalZooArr, animalZooArr.Length +1);
            // animalZooArr[^1] = animal;
        }

        public bool HasAnimal<TSpecies> () where  TSpecies : TAnimal
        {
            for (int i = 0; i < animals.Count(); i++)
            {
                if (animals[i] is TSpecies ) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
