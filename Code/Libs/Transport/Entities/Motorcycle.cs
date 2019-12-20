namespace Transports.Code.Libs
{
    class Motorcycle : Transport
    {
        public Motorcycle(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
               : base(
                     model,
                     false,
                     0,
                     true,
                     2,
                     passengersCount,
                     MoveType.Line,
                     FuelType.Diesel,
                     TransportRole.Passenger,
                     false,
                     LightType.Headlight,
                     ownerAge,
                     stamina,
                     startSpeed,
                     maxSpeed)
        {
        }
    }
}
