using CoolParking.BL.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Parking 
{
    public decimal Balance { get; set; }
    public int Capacity { get; set; }
    public List<Vehicle> Vehicles { get; set; }



    public Parking()
    {
        Capacity = Settings.Capacity;
        Balance = Settings.Balance;
    }


}
// TODO: implement class Parking.
//       Implementation details are up to you, they just have to meet the requirements 
//       of the home task and be consistent with other classes and tests.
