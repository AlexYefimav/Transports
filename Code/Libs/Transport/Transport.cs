using System;

namespace Transports.Code.Libs
{
    class Transport : ITransport
    {
        public Transport() { }

        #region Variables
        private int logId = 0;

        private string model = "";
        private bool haveDoors = false;
        private int doorsCount = 0;
        private bool haveWheels = false;
        private int wheelsCount = 0;
        private int passangersCount = 1;
        private MoveType move;
        private FuelType fuel;
        private TransportRole role;
        private bool haveAlarm = false;
        private LightType light;
        private int ownerAge = 1;
        private int stamina = 1;
        private int startSpeed = 1;
        private int maxSpeed = 1;

        protected Transport(
            string model, 
            bool haveDoors, 
            int doorsCount, 
            bool haveWheels, 
            int wheelsCount, 
            int passangersCount, 
            MoveType move, 
            FuelType fuel, 
            TransportRole role, 
            bool haveAlarm, 
            LightType light, 
            int ownerAge,
            int stamina,
            int startSpeed,
            int maxSpeed)
        {
            Model = model;
            HaveDoors = haveDoors;
            DoorsCount = doorsCount;
            HaveWheels = haveWheels;
            WheelsCount = wheelsCount;
            PassangersCount = passangersCount;
            Move = move;
            Fuel = fuel;
            Role = role;
            HaveAlarm = haveAlarm;
            Light = light;
            OwnerAge = ownerAge;
            Stamina = stamina;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
        }

        public string Log { get; set; } = "";

        public int Id { get; set; }

        public string Model {
            get {
                return model;
            }
            set
            {
                Log += LogTemplate("Модель изменена на " + value.ToString());
                model = value;
            }
        }

        public bool HaveDoors
        {
            get
            {
                return haveDoors;
            }
            set
            {
                Log += LogTemplate("Наличие дверей установлено на " + value.ToString());
                haveDoors = value;
            }
        }

        public int DoorsCount {
            get
            {
                return doorsCount;
            }
            set
            {
                Log += LogTemplate("Кол-во дверей установлено на " + value.ToString());
                doorsCount = value;
            }
        }

        public bool HaveWheels
        {
            get
            {
                return haveWheels;
            }
            set
            {
                Log += LogTemplate("Наличие колёс установлено на " + value.ToString());
                haveWheels = value;
            }
        }

        public int WheelsCount
        {
            get
            {
                return wheelsCount;
            }
            set
            {
                Log += LogTemplate("Кол-во колёс установлено на " + value.ToString());
                wheelsCount = value;
            }
        }

        public int PassangersCount
        {
            get
            {
                return passangersCount;
            }
            set
            {
                Log += LogTemplate("Кол-во пассажиров установлено на " + value.ToString());
                passangersCount = value;
            }
        }

        public MoveType Move
        {
            get
            {
                return move;
            }
            set
            {
                Log += LogTemplate("Движение изменено на " + value.ToString());
                move = value;
            }
        }

        public FuelType Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                Log += LogTemplate("Вид топлива установлена на " + value.ToString());
                fuel = value;
            }
        }

        public TransportRole Role
        {
            get
            {
                return role;
            }
            set
            {
                Log += LogTemplate("Роль установлена на " + value.ToString());
                role = value;
            }
        }

        public bool HaveAlarm
        {
            get
            {
                return haveAlarm;
            }
            set
            {
                Log += LogTemplate("Наличие сигнализации установлена на " + value.ToString());
                haveAlarm = value;
            }
        }

        public LightType Light
        {
            get
            {
                return light;
            }
            set
            {
                Log += LogTemplate("Вид света установлена на " + value.ToString());
                light = value;
            }
        }

        public int OwnerAge
        {
            get
            {
                return ownerAge;
            }
            set
            {
                Log += LogTemplate("Возраст владельца установлена на " + value.ToString());
                ownerAge = value;
            }
        }

        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                Log += LogTemplate("Макс. км. без остановок установлена на " + value.ToString());
                stamina = value;
            }
        }

        public int StartSpeed
        {
            get
            {
                return startSpeed;
            }
            set
            {
                Log += LogTemplate("Начальная скорость установлена на " + value.ToString());
                startSpeed = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                Log += LogTemplate("Максимальная скорость установлена на " + value.ToString());

                maxSpeed = value;
            }
        }

        public bool isGlassOpen { get; set; } = false;
        public bool isDoorOper { get; set; } = false;
        public bool isMoving { get; set; } = false;
        public bool isLightOn { get; set; } = false;

        public int CurrentSpeed { get; set; } = 1;
        public int CurrentPassangers { get; set; } = 1;

        public int CurrentStamina { get; set; } = 1;

        #endregion

        #region Methods

        public void OpenGlass()
        {
            if (!HaveDoors || isGlassOpen)
            {
                return;
            }

            Log += LogTemplate("Открыл стёкла");
            isGlassOpen = true;
        }

        public void CloseGlass()
        {
            if (!HaveDoors || !isGlassOpen)
            {
                return;
            }

            Log += LogTemplate("Закрыл стёкла");
            isGlassOpen = false;
        }

        public void OpenDoor()
        {
            if (!HaveDoors || isDoorOper)
            {
                return;
            }

            Log += LogTemplate("Открыл двери");
            isDoorOper = true;
        }

        public void CloseDoor()
        {
            if (!HaveDoors || !isDoorOper)
            {
                return;
            }

            Log += LogTemplate("Закрыл стёкла");
            isDoorOper = false;
        }

        public void StartMoving()
        {
            if (isMoving)
            {
                return;
            }

            Log += LogTemplate("Начал движение");
            isMoving = true;
        }

        public void StopMoving()
        {
            if (!isMoving)
            {
                return;
            }

            Log += LogTemplate("Закончил движение");
            isMoving = false;
        }

        public void OnLight()
        {
            if (isLightOn)
            {
                return;
            }

            Log += LogTemplate("Включил осветительные приборы");
            isLightOn = true;
        }

        public void OffLight()
        {
            if (!isLightOn)
            {
                return;
            }

            Log += LogTemplate("Выключил осветительные приборы");
            
            isLightOn = false;
        }

        public void ToMaxSpeed()
        {
            Log += LogTemplate("Скорость установлена на максимальную:" + MaxSpeed);


            CurrentSpeed = MaxSpeed;
        }

        public void ToNormalSpeed()
        {
            Log += LogTemplate("Скорость установлена на обычную:" + StartSpeed);


            CurrentSpeed = StartSpeed;
        }

        public void ChangePassangers(int value)
        {
            if (value < 0 && Math.Abs(value) > CurrentPassangers)
            {
                value = -CurrentPassangers;
            }

            Log += LogTemplate("Кол-во пассажиров изменено на:" + value.ToString());

            CurrentPassangers += value;
        }

        public void FullFuel()
        {
            Log += LogTemplate("Бак заправлен");
            CurrentStamina = Stamina;
        }

        public string LogTemplate(string message)
        {
            return $"[{++logId}]" + message + ";\n";
        }

        #endregion
    }
}
