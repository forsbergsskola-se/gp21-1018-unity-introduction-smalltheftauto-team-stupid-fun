using System;

namespace ZooEK {
    abstract class Program {
        static void Main()
        {

        }

        // public Animal AddAnimal<TAnimals>() {
        //     Animal animal = new Animal();
        //     if (typeof(TAnimals) is Animal) {
        //         return animal;
        //     } else {
        //         return null;
        //     }
        // }

    }

    class Zoo<TAnimals> where TAnimals : Animal {

        //Animal[] zooAnimals = { };
        private Animal[] animalZoo = new Animal[0];
        public Zoo<Fish> fishZoo = new Zoo<Fish>();
        public Zoo<Lion> lionZoo = new Zoo<Lion>();
        public Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();
        public Zoo<Mammal> mammalZoo = new Zoo<Mammal>();

        //Zoo<Fish> fishZoo = new Zoo<Fish>();
        //Console.WriteLine("This should be True: "+fishZoo.HasAnimal<Clownfish>());

        // public bool HasAnimal<TAnimals>() {
        //     if () {
        //         return true;
        //     } else {
        //         return false;
        //     }
        // }

        public void AddAnimal(TAnimals animal) {
            Array.Resize<Animal>(ref animalZoo, animalZoo.Length + 1);
            animalZoo[animalZoo.Length - 1] = animal;
        }
    }

    class Animal {
        //string name;
        //public override string ToString() => GetType().Name;
    }

    class Mammal : Animal { }
    class Bear : Mammal { }
    class Donkey : Mammal { }
    class Lion : Mammal { }
    class Fish : Animal { }
    class Salmon : Fish { }
    class Clownfish : Fish { }
    class Student { }
}
