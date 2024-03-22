using CircleLab2024;

circle circle1 = new circle(0);

while (true)
{
    Console.Write("Please enter the radius of the circle: ");
    if (double.TryParse(Console.ReadLine(), out double input))
    {
        circle1.radius = input;

        Console.WriteLine($"Diameter: {circle1.CalcDiameter()}" +
            $"\nCircumference: {circle1.CalcCircumference()}" +
            $"\nArea: {circle1.CalcArea()}");
        break;
    }

    else
    {
        Console.WriteLine("Not valid input. Try again.");
        Thread.Sleep(1500);
        Console.Clear();
    }
}

while (true)
{
    Console.Write("\nShould the circle grow? (y/n) ");
    string growChoice = Console.ReadLine().ToLower();

    if (growChoice == "y")
    {
        Console.WriteLine("\nThe circle is magically growing...");
        circle1.Grow();
        Console.WriteLine($"\nDiameter: {circle1.CalcDiameter()}" +
    $"\nCircumference: {circle1.CalcCircumference()}" +
    $"\nArea: {circle1.CalcArea()}");
    }
    else if (growChoice == "n")
    {
        Console.WriteLine($"\nGoodbye. The circle's final radius is {circle1.GetRadius()}");
        break;
    }
    else
    {
        Console.WriteLine($"\nThat wasn't y or n. Assuming you want to stop. The final radius is {circle1.GetRadius()}");
        break;
    }
}

