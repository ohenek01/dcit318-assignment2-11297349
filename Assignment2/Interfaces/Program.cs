using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("The car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("The bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}