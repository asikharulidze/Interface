namespace Interface;


public interface ISwimmable
{
    void Swim();
}


public interface IFlyable
{
    void Fly();
}


public class Dog : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("The dog swims.");
    }
}


public class Bird : ISwimmable, IFlyable
{
    public void Swim()
    {
        Console.WriteLine("The bird swims.");
    }

    public void Fly()
    {
        Console.WriteLine("The bird flies.");
    }
}


public class Fish : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("The fish swims.");
    }
}


public class Program
{
    public static void Main()
    {
        ISwimmable dog = new Dog();
        ISwimmable bird = new Bird();
        IFlyable flyingBird = new Bird();
        ISwimmable fish = new Fish();

        dog.Swim();       
        bird.Swim();      
        flyingBird.Fly(); 
        fish.Swim();      
    }
}
