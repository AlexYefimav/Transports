namespace Transports.Code.Libs
{
    class Bicycle : Transport
    {
        public Bicycle(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
            : base(
                  model, 
                  false, 
                  0, 
                  true,
                  2, 
                  passengersCount, 
                  MoveType.Line,
                  FuelType.Energy, 
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
