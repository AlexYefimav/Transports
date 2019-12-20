namespace Transports.Code.Libs
{
    class Tank : Transport
    {
        public Tank(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
                    : base(
                          model,
                          false,
                          0,
                          false,
                          0,
                          passengersCount,
                          MoveType.Line,
                          FuelType.Petrol,
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
