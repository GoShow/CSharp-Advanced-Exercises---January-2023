using System;

namespace SpeedRacing;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelledDistance;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public double FuelConsumptionPerKilometer
    {
        get { return fuelConsumptionPerKilometer; }
        set { fuelConsumptionPerKilometer = value; }
    }

    public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }

    public void Drive(double distance)
    {
        if (distance * FuelConsumptionPerKilometer > fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            FuelAmount -= distance * FuelConsumptionPerKilometer;
            TravelledDistance += distance;
        }
    }
}
