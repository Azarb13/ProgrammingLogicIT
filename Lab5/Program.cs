namespace Lab5;

internal class Program
{
    private static void Main(string[] args)
    { }
    // Step 1 Base Class
    public class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    // Step 2 – Derived - Cat
    public class Cat : Animal
    {

        public override void animalSound()
        {
            Console.WriteLine("Cat says: meow");
        }
    }

    // Step 2 – Derived - Dog
    public class Dog : Animal
    {

        public override void animalSound()
        {
            Console.WriteLine("Dog says: Wruff, Wruff");
        }
    }

    // Step 3 – Test in Main()
    private class Program
    {
        private static void Main(string[] args)
        {
            //  objects using Animal as reference type (polymorphism)
            Animal myAnimal = new Animal(); 
            Animal myCat = new Cat();       
            Animal myDog = new Dog();       

            //  animalSound() on each
            myAnimal.animalSound(); // Should say: The animal makes a sound
            myCat.animalSound();    // Should say: Cat says: meow
            myDog.animalSound();    // Should say: Dog says: Wruff
        }
    }
}


