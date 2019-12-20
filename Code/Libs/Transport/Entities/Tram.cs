namespace Transports.Code.Libs
{
    class Tram : Transport
    {
        public Tram(string model, int passengersCount, int ownerAge,  int stamina, int startSpeed, int maxSpeed)
             : base(
                   model,
                   true,
                   4,
                   true,
                   8,
                   passengersCount,
                   MoveType.Rails,
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
