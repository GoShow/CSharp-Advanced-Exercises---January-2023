using System.Collections.Generic;

namespace SoftUniParking;

public class Parking
{
    private Dictionary<string, Car> cars;
    private int capacity;

    public Parking(int capacity)
    {
        this.capacity = capacity;
        cars = new();
    }

    public int Count { get { return this.cars.Count; } }

    public string AddCar(Car car)
    {
        if (cars.ContainsKey(car.RegistrationNumber))
        {
            return "Car with that registration number, already exists!";
        }

        if (cars.Count == capacity)
        {
            return "Parking is full!";
        }

        this.cars.Add(car.RegistrationNumber, car);

        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public Car GetCar(string registrationNumber)
    {
        return cars[registrationNumber];
    }

    public string RemoveCar(string registrationNumber)
    {
        if (!cars.ContainsKey(registrationNumber))
        {
            return "Car with that registration number, doesn't exist!";
        }

        cars.Remove(registrationNumber);

        return $"Successfully removed {registrationNumber}";
    }

    public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
    {
        foreach (var registrationNumber in registrationNumbers)
        {
            RemoveCar(registrationNumber);
        }
    }
}