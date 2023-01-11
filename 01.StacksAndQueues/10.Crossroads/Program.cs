using System;
using System.Collections.Generic;
using System.Linq;

int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> cars = new();

int passedCars = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "END")
    {
        break;
    }

    if (input != "green")
    {
        cars.Enqueue(input);
        continue;
    }

    int currentGreenLight = greenLight;

    while (currentGreenLight > 0 && cars.Any())
    {
        string currentCar = cars.Dequeue();

        if (currentGreenLight - currentCar.Length >= 0)
        {
            currentGreenLight -= currentCar.Length;
            passedCars++;
            continue;
        }

        if (currentGreenLight + freeWindow - currentCar.Length >= 0)
        {
            passedCars++;
            continue;
        }

        int hittedChar = currentGreenLight + freeWindow;

        Console.WriteLine("A crash happened!");
        Console.WriteLine($"{currentCar} was hit at {currentCar[hittedChar]}.");

        return;
    }
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");