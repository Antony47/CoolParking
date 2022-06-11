// TODO: implement class Vehicle.
public class Vehicle
{
    public string Id { get;}
    private VehicleType Type { get;}
    public decimal Balance { get; set; }

    public Vehicle(string id, VehicleType type, decimal balance)
    {
        this.Id = id;
        this.Type = type;
        this.Balance = balance;
    }


}
//       Properties: Id (string), VehicleType (VehicleType), Balance (decimal).
//       The format of the identifier is explained in the description of the home task.
//       Id and VehicleType should not be able for changing.
//       The Balance should be able to change only in the CoolParking.BL project.
//       The type of constructor is shown in the tests and the constructor should have a validation, which also is clear from the tests.
//       Static method GenerateRandomRegistrationPlateNumber should return a randomly generated unique identifier.
