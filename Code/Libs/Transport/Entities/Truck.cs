namespace Transports.Code.Libs
{
    class Truck : Transport
    {
        public Truck(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
            : base(
                  model,
                  true,
                  2,
                  true,
                  6,
                  passengersCount,
                  MoveType.Road,
                  FuelType.Diesel,
                  TransportRole.Freight,
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
