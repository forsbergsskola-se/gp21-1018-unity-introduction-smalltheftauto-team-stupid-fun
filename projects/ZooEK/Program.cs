using System;

namespace ZooEK {

    abstract class Program {

        static void Main() {

        }

        public void AddAnimal<TAnimals>() {
            Animal animal = new Animal();
        }

        // public bool HasAnimal() {
        //     if (Animal) {
        //         return true;
        //     } else {
        //         return false;
        //     }
        // }
    }

    class Zoo<TAnimals> where TAnimals : Animal {
        protected string[] zooAnimals = {"Animal"};
    }

    class Animal {
        public override string ToString() => GetType().Name;
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
