namespace InterfaceSegregation;

abstract class Animal
{
    public abstract void Feed();
}

abstract class Pet : Animal
{
    public abstract void Groom();
}


class Dog : Pet
{
    public override void Feed()
        => Console.WriteLine("Dog Feed");

    public override void Groom()
        => Console.WriteLine("Dog Groom");
}

class Tiger : Animal
{
    public override void Feed()
        => Console.WriteLine("Tiger Feed");
}