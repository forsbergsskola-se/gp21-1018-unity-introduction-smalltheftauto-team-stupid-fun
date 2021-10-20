using System;
using System.Threading.Channels;

namespace ZooPS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Zoo<Animal> animalZoo = new Zoo<Animal>();
            animalZoo.AddAnimal(new Fish()); 
            animalZoo.AddAnimal(new Clownfish()); 
            animalZoo.AddAnimal(new Lion()); 
            animalZoo.AddAnimal(new Donkey());
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
        private Animal[] animalZoo = new Animal[0];
        
        public void AddAnimal(TAnimal animal)  
        {
            Array.Resize(ref animalZoo, animalZoo.Length +1);
            animalZoo[animalZoo.Length -1] = animal;
        }

        public void HasAnimal ()
        {
            
        }
    }
}
