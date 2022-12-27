public class ConcreteVehicleFactory : VehicleFactory
{
    public override IFactory GetVehicle(string Vehicle)
    {
        switch (Vehicle)
        {
            case "Scooter":
                return new Scooter();
            case "Bike":
                return new Bike();
            default:
                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
        }
    }
}
