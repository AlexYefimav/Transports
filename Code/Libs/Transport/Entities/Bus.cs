namespace Transports.Code.Libs
{
    class Bus : Transport
    {
        public Bus(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
               : base(
                     model,
                     true,
                     4,
                     true,
                     6,
                     passengersCount,
                     MoveType.Road,
                     FuelType.Petrol,
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
