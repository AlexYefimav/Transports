using System;
using System.Collections.Generic;

using Word = Microsoft.Office.Interop.Word;

using Transports.Code.Model;
using Transports.Code.View;

using Transports.Code.Libs;

namespace Transports.Code.Presenter
{
    class RoadService : IRoadService
    {
        private readonly IRoadRepository repo;
        private readonly ITransportRepository transportRepo;
        private readonly IMainService mainServ;

        public IRoadController Contr { get; set; }

        public RoadService(IRoadRepository repo, IRoadController contr, ITransportRepository transportRepo, IMainService mainServ)
        {
            this.repo = repo;
            this.transportRepo = transportRepo;
            this.mainServ = mainServ;

            Contr = contr;
        }

        public void Init(RoadForm form)
        {
            Contr.Init(form);
        }


        public void Start()
        {
            var movableRoad = GetMovableRoad();

            Contr.Start(movableRoad);
        }

        public void Pause()
        {
            var movableRoad = GetMovableRoad();

            Contr.Pause(movableRoad);
        }

        public void Continue()
        {
            var movableRoad = GetMovableRoad();

            Contr.Continue(movableRoad);
        }


        public IRoad GetRoad(int id)
        {
            return repo.Find(id);
        }

        public IList<IRoad> GetRoads()
        {
            return repo.FindAll();
        }

        public IList<int> GetMovableRoad()
        {
            var movableRoad = new List<int>();
            var roads = repo.FindAll();
            var transports = transportRepo.FindAll();

            for (var i = 0; i < 5; i++)
            {
                if (roads[i].MoveType == MoveType.Rails)
                {
                    if (transports[i].Transport.GetType() == typeof(Tram))
                    {
                        movableRoad.Add(i);
                    }
                }
                else if (roads[i].MoveType == MoveType.Line)
                {
                    if (transports[i].Transport.GetType() == typeof(Cart) 
                        || transports[i].Transport.GetType() == typeof(Bicycle) 
                        || transports[i].Transport.GetType() == typeof(Scooter) 
                        || transports[i].Transport.GetType() == typeof(Tank))
                    {
                        movableRoad.Add(i);
                    }
                }
                else if (roads[i].MoveType == MoveType.Road)
                {
                    if (transports[i].Transport.GetType() == typeof(Bus)
                         || transports[i].Transport.GetType() == typeof(Car)
                         || transports[i].Transport.GetType() == typeof(Loader)
                         || transports[i].Transport.GetType() == typeof(Truck))
                    {
                        movableRoad.Add(i);
                    }
                }
                else if (roads[i].MoveType == MoveType.Wires)
                {
                    if (transports[i].Transport.GetType() == typeof(Trolley))
                    {
                        movableRoad.Add(i);
                    }
                }

            }

            return movableRoad;
        }

        public void SetRoadType(int id)
        {
            repo.Find(id).MoveType = (MoveType)Contr.GetSelectedIndex(id);
        }


        private void CheckRoad(IRoad road, int newId)
        {
            var id = road.XPos + newId;

            if (id >= road.RoadPeaces.Count)
            {
                id = road.RoadPeaces.Count - 1;
            }

            var newTransport = repo.Find(road.Id);

            for (var i = road.XPos + 1; i < id; i++)
            {
                if (newTransport.RoadPeaces[i] == newTransport.TransportStationTemplate)
                {
                    transportRepo.Find(road.Id).Transport.FullFuel();
                }

                if (i % 5 == 0)
                {
                    transportRepo.AddLogs(road.Id, "Проехано 50км");
                }
            }
        }

        private void UpdateRoad(IRoad road, int newId)
        {
            var id = road.XPos + newId;
            if (id >= road.RoadPeaces.Count)
            {
                id = road.RoadPeaces.Count - 1;
            }

            repo.Find(road.Id).XTemp = road.RoadPeaces[id];

            repo.Find(road.Id).RoadPeaces[road.XPos] = road.XTemp;

            repo.Find(road.Id).RoadPeaces[id] = road.TransportTemplate;

            repo.Find(road.Id).XPos = road.XPos + newId;
        }


        public ITransportData GetTransport(int id)
        {
            return transportRepo.Find(id);
        }


        public void SetMoving(int id)
        {
            transportRepo.Find(id).Transport.StartMoving();
        }

        public void SetStoped(int id)
        {
            transportRepo.Find(id).Transport.StopMoving();
        }

        public void SetFullFuel(int id)
        {
            transportRepo.Find(id).Transport.FullFuel();
        }


        public void MoveTransport(int roadId, int newId)
        {
            var road = repo.Find(roadId);

            var transportData = transportRepo.Find(roadId);

            ChangeSpeed(transportData);

            if (!CheckMovement(transportData, roadId, newId))
            {
                return;
            }

            if ((road.XPos + newId) % 5 == 0)
            {
                transportRepo.AddLogs(roadId, "Проехано 50км");
            }

            transportRepo.Find(roadId).Transport.CurrentStamina -= newId;

            CheckRoad(road, newId);
            UpdateRoad(road, newId);
        }


        private void ChangeSpeed(ITransportData transportData)
        {
            if (transportData.Transport.CurrentStamina <= transportData.Transport.Stamina / 2)
            {
                if (transportData.Transport.CurrentSpeed != transportData.Transport.MaxSpeed)
                {
                    transportData.Transport.ToMaxSpeed();
                }
            }
            else
            {
                if (transportData.Transport.CurrentSpeed != transportData.Transport.StartSpeed)
                {
                    transportData.Transport.ToNormalSpeed();
                }
            }
        }

        private bool CheckMovement(ITransportData transportData, int roadId, int newId)
        {
            if (transportData.Transport.CurrentStamina == 0)
            {
                return false;
            }
            else if (transportData.Transport.CurrentStamina < newId)
            {
                MoveTransport(roadId, transportData.Transport.CurrentStamina);

                return false;
            }
            else if (!transportData.Transport.isMoving)
            {
                return false;
            }

            return true;
        }

   
        public void ShowLog(int id)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();

            Word.Paragraph par = doc.Paragraphs.Last;
            par.Range.Text = transportRepo.Find(id).Transport.Log;
            
            try
            {
                doc.Close();
            }
            catch (Exception e)
            {
                Contr.ShowMessage("Ошибка при записи в файл.");
            }

            Contr.ShowMessage(transportRepo.Find(id).Transport.Log);
        }


        public void SetTSCount()
        {
            mainServ.TSCount = GetTSCount();
        }

        private int GetTSCount()
        {
            var transports = transportRepo.FindAll();
            var count = 0;

            foreach (var t in transports)
            {
                if (t.Transport == null)
                {
                    continue;
                }

                if (t.Transport.isMoving)
                {
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                mainServ.IncMovingTime();
            }

            if (count == 0)
            {
                return count;
            }

            for (int i = 0; i < 5 - count; i++)
            {
                mainServ.IncStopTime();
            }

            return count;
        }
    }
}
