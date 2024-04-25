// Яким чином можна відрефакторити данний код?

class Engine
{
    public int Volume { get; set; }
}

class Car
{
    public Engine Engine { get; set; }

    public string Model { get; set; }

    public Car(Engine engine)
    {
        Engine = engine;
    }

    public Car(Engine engine, string model)
    {
        Engine = engine;
        Model = model;
    }

    public void StartTrip()
    {
        Console.WriteLine($"Engine with Volume - {Engine.Volume} start work ");
        Console.WriteLine($"Car - {Model} start trip ");
    }
}