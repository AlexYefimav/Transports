namespace Transports.Code.Libs
{
    class Car : Transport
    {
        public Car(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
          : base(
                model,
                true,
                4,
                true,
                4,
                passengersCount,
                MoveType.Road,
                FuelType.Diesel,
                TransportRole.Passenger,
                true,
                LightType.Headlight,
                ownerAge,
                stamina,
                startSpeed,
                maxSpeed)
        {
        }
    }
}
