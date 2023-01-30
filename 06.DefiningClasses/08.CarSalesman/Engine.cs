using System;

namespace CarSalesman;

public class Engine
{
    public Engine(string model, int power)
    {
        Model = model;
        Power = power;
    }

    public string Model { get; set; }
    public int Power { get; set; }
    public int Displacement { get; set; }
    public string Efficiency { get; set; }

    public override string ToString()
    {
        string displacement = Displacement == 0 ? "n/a" : Displacement.ToString();
        string efficiency = Efficiency ?? "n/a";

        string result =
            $"{Model}:{Environment.NewLine}" +
            $"    Power: {Power}{Environment.NewLine}" +
            $"    Displacement: {displacement}{Environment.NewLine}" +
            $"    Efficiency: {efficiency}";

        return result;
    }
}
