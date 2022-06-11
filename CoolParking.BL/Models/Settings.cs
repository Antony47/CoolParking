using System;
using System.Collections.Generic;

public static class Settings
{
    public const decimal Balance = 0;
    public const int Capacity = 10;
    public const int Timeout = 5;
    public const int LogTimeout = 60;
    public const double Сoefficient = 2.5;
    private static readonly Dictionary<VehicleType, double> Price = new Dictionary<VehicleType, double>(4)
    {
        {VehicleType.PassengerCar, 2},
        {VehicleType.Truck, 5},
        {VehicleType.Bus, 3.5},
        {VehicleType.Motorcycle, 1}  
    };

}

// TODO: implement class Settings.
//       Implementation details are up to you, they just have to meet the requirements of the home task.
