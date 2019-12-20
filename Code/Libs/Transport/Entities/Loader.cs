namespace Transports.Code.Libs
{
    class Loader : Transport
    {
        public Loader(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
        : base(
           model,
           true,
           2,
           true,
           6,
           passengersCount,
           MoveType.Road,
           FuelType.Petrol,
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
