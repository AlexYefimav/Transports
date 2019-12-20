namespace Transports.Code.Libs
{
    class Scooter : Transport
    {
        public Scooter(string model, int passengersCount, int ownerAge, int stamina, int startSpeed, int maxSpeed)
                 : base(
                       model,
                       false,
                       0,
                       true,
                       2,
                       passengersCount,
                       MoveType.Line,
                       FuelType.Gas,
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
