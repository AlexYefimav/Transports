namespace Transports.Code.Libs
{
    interface ITransport : IEntity
    {
        string Log { get; set; }

        string Model { get; set; }
        bool HaveDoors { get; set; }
        int DoorsCount { get; set; }
        bool HaveWheels { get; set; }
        int WheelsCount { get; set; }
        int PassangersCount { get; set; }
        MoveType Move { get; set; }
        FuelType Fuel { get; set; }
        TransportRole Role { get; set; }
        bool HaveAlarm { get; set; }
        LightType Light { get; set; }
        int OwnerAge { get; set; }
        int Stamina { get; set; }
        int StartSpeed { get; set; }
        int MaxSpeed { get; set; }
        bool isGlassOpen { get; set; }
        bool isDoorOper { get; set; }
        bool isMoving { get; set; }
        bool isLightOn { get; set; }
        int CurrentSpeed { get; set; }
        int CurrentPassangers { get; set; }
        int CurrentStamina { get; set; }

        void OpenGlass();
        void CloseGlass();
        void OpenDoor();
        void CloseDoor();
        void StartMoving();
        void StopMoving();
        void OnLight();
        void OffLight();
        void ToMaxSpeed();
        void ToNormalSpeed();
        void ChangePassangers(int value);
        void FullFuel();
        string LogTemplate(string message);
    }
}
