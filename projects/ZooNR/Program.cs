using System;

namespace ZooNR
{
    class Program
    {
        static void Main()
        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Fish());
            fishZoo.AddAnimal(new Clownfish());
            fishZoo.HasAnimal<Mammal>();
            fishZoo.HasAnimal<Salmon>();
        }
    }


    class Zoo<TAnimal>  where TAnimal : Animal
    {
        
        TAnimal[] AnimalArray = new TAnimal[0];
        
        public void AddAnimal(TAnimal animal)
        {
            Array.Resize(ref AnimalArray, AnimalArray.Length+1);
            AnimalArray[AnimalArray.Length-1] = animal;
        }

        public bool HasAnimal<TAnimal>()
        {
            bool result = false;
            
            for (int i = 0; i < AnimalArray.Length; i++)
            {
                if (AnimalArray[i] is TAnimal)
                {
                    result = true;
                     break;
                }
                else
                {
                     result = false;
                }
            }

            Console.WriteLine(result);
            return result;
        }
        
    }
    
    class Student
    {
        
    }
    
    class Animal
    {
        
    }
    
    class Fish : Animal
    {
        
    }

    class Mammal : Animal
    {
        
    }

    class Bear : Mammal
    {
        
    }
    
    class Donkey : Mammal
    {
        
    }
    
    class Lion : Mammal
    {
        
    }
    
    class Salmon : Fish
    {
        
    }
    
    class Clownfish : Fish
    {
        
    }
    
}
