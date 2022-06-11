using CoolParking.BL.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.Linq;

public class ParkingService : IParkingService
{
    private bool disposed = false;

    public Parking parking { get; set; }
    public TimerService WithdrawTimer { get; set; }
    public TimerService LogTimer { get; set; }


    public ParkingService()
    {
        parking = new Parking();
    }


    public ParkingService(ITimerService withdrawTimer, ITimerService logTimer, ILogService parkingService)
    {
        WithdrawTimer = (TimerService)withdrawTimer;
        LogTimer = (TimerService)logTimer;

    }


    public void AddVehicle(Vehicle vehicle)
    {
        if(parking.Capacity == parking.Vehicles.Count)
        {
            throw new InvalidOperationException();
        }
        parking.Vehicles.Add(vehicle);

    }

    public void Dispose()
    {

        Dispose(true);

        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                WithdrawTimer.Dispose();
                LogTimer.Dispose();
            }


            disposed = true;
        }
    }

    public decimal GetBalance()
    {
        return parking.Balance;  
    }

    public int GetCapacity()
    {
        return parking.Capacity;
    }

    public int GetFreePlaces()
    {
        return (parking.Capacity - parking.Vehicles.Count);
    }

    public TransactionInfo[] GetLastParkingTransactions()
    {
        throw new System.NotImplementedException();
    }

    public ReadOnlyCollection<Vehicle> GetVehicles()
    {
        ReadOnlyCollection<Vehicle> res = new ReadOnlyCollection<Vehicle>(parking.Vehicles);
        return res;
    }

    public string ReadFromLog()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveVehicle(string vehicleId)
    {
        Vehicle currentVehicle = parking.Vehicles.Find(x => x.Id == vehicleId);
        if (currentVehicle != null && currentVehicle.Balance >= 0)
        {
            parking.Vehicles.Remove(currentVehicle);
        }
    }

    public void TopUpVehicle(string vehicleId, decimal sum)
    {
        throw new System.NotImplementedException();
    }
}


// TODO: implement the ParkingService class from the IParkingService interface.
//       For try to add a vehicle on full parking InvalidOperationException should be thrown.
//       For try to remove vehicle with a negative balance (debt) InvalidOperationException should be thrown.
//       Other validation rules and constructor format went from tests.
//       Other implementation details are up to you, they just have to match the interface requirements
//       and tests, for example, in ParkingServiceTests you can find the necessary constructor format and validation rules.
