using System;
using System.Collections.Generic;

namespace ZooEK {
    abstract class Program {
        static void Main() {

             Zoo<Animal> animalZoo = new Zoo<Animal>();
             animalZoo.AddAnimal(new Fish()); // OKAY
             animalZoo.AddAnimal(new Clownfish()); // OKAY
             animalZoo.AddAnimal(new Lion()); // OKAY
             animalZoo.AddAnimal(new Donkey()); // OKAY

             Zoo<Lion> lionZoo = new Zoo<Lion>();
             lionZoo.AddAnimal(new Lion()); // OKAY
             lionZoo.AddAnimal(new Lion()); // OKAY
             lionZoo.AddAnimal(new Lion()); // OKAY

             Zoo<Fish> fishZoo = new Zoo<Fish>();
             fishZoo.AddAnimal(new Salmon());
             fishZoo.AddAnimal(new Salmon());
             Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
        }
    }

    class Zoo<TAnimal> where TAnimal : Animal {
        // instead of TAnimal[] animals = new TAnimal[0];
        //TAnimal[] animals = Array.Empty<TAnimal>();
        List<TAnimal> animals = new List<TAnimal>();

        public void AddAnimal(TAnimal animal) {
            animals.Add(animal);
        }

        public bool HasAnimal<TSpecies>() where TSpecies : TAnimal {
            for (int i = 0; i < animals.Count; i++) {
                if (animals[i] is TSpecies) {
                    return true;
                }
            }
            return false;
        }
    }

    class Animal { }
    class Mammal : Animal { }
    class Bear : Mammal { }
    class Donkey : Mammal { }
    class Lion : Mammal { }
    class Fish : Animal { }
    class Salmon : Fish { }
    class Clownfish : Fish { }
    class Student { }
}
