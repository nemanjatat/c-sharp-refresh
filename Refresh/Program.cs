using Refresh;

class Program
{
    static void Main(string[] args)
    {
        // method overriding = provides a new version of a method inherited from a parent class
        //                     inherited method must be: abstract, virtual, or already overriden
        //                     Used with ToString(), polymorphism

        Animal fox = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        fox.Speak();
        dog.Speak();
        cat.Speak();

        Console.ReadLine();
    }
}