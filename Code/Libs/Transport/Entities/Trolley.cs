namespace Transports.Code.Libs
{
    class Trolley : Transport
    {
        public Trolley(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
            : base(
                  model,
                  true,
                  4,
                  true,
                  6,
                  passengersCount,
                  MoveType.Wires,
                  FuelType.Diesel,
                  TransportRole.Public,
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
