namespace Transports.Code.Libs
{
    class Cart : Transport
    {
        public Cart(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
            : base(
                  model,
                  false,
                  0,
                  true,
                  4,
                  passengersCount,
                  MoveType.Line,
                  FuelType.Energy,
                  TransportRole.Passenger,
                  true,
                  LightType.Torch,
                  ownerAge,
                  stamina,
                  startSpeed,
                  maxSpeed)
        {
        }
    }
}
