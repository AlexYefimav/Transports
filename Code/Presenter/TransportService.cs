using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transports.Code.Libs;
using Transports.Code.Model;
using Transports.Code.View;

namespace Transports.Code.Presenter
{
    class TransportService : ITransportService
    {
        readonly IFuelRepository fuelRepo;
        readonly ITransportRepository repo;
        readonly IRoadRepository roadRepo;

        public ITransportController Contr { get; set; }

        public TransportService(ITransportRepository repo, ITransportController contr, IFuelRepository fuelRepo, IRoadRepository roadRepo)
        {
            this.repo = repo;
            this.fuelRepo = fuelRepo;
            this.roadRepo = roadRepo;

            Contr = contr;
        }

        public void Init(SelectTransport form)
        {
            Contr.Init(form);
            Contr.UpdateStatusBar(form);
        }

        public bool SetTransportType(int id, int value)
        {
            var transport = GetNewTransportById(value);

            var check = repo.Find(id);

            if (check.Transport != null)
            {
                if (transport.GetType() == check.Transport.GetType())
                {
                    return true;
                }
            }
            

            repo.Find(id).Transport = transport;

            var fuels = fuelRepo.FindAll();
            bool isFuelFind = false;
            foreach (var f in fuels)
            {
                if (f.Type == transport.Fuel)
                {
                    isFuelFind = true;
                    break;
                }
            }

            if (!isFuelFind)
            {
                return isFuelFind;
            }

            repo.SetTransportType(id, value);

            return isFuelFind;
        }

        public ITransportData GetTransport(int id)
        {
            return repo.Find(id);
        }

        public IList<IFuel> GetFuelsList()
        {
            return fuelRepo.FindAll();
        }

        public IFuel GetFuel(int id)
        {
            return fuelRepo.Find(id);
        }

        public void SaveData(SelectTransport form)
        {
            var id = Contr.GetSelectedTransport();

            if (id == null)
            {
                Contr.ShowMessage("Трансопорт не выбран!");
                return;
            }

            if (!UpdateData(id.Value))
            {
                return;
            }

            Contr.ShowMessage("Данные установлены!");
        }

        public bool UpdateData(int id)
        {
            var newTransp = GetTransport(id);

            if (newTransp.Transport == null)
            {
                Contr.ShowMessage("Вид транспорта не выбран!");
                return false;
            }

            newTransp.Transport.Model = Contr.Model.Text;
            newTransp.Transport.PassangersCount = (int)Contr.Input[0].Value;
            newTransp.Transport.OwnerAge = (int)Contr.Input[1].Value;
            newTransp.Transport.Stamina = (int)Contr.Input[2].Value;
            newTransp.Transport.CurrentStamina = newTransp.Transport.Stamina;
            newTransp.Transport.StartSpeed = (int)Contr.Input[3].Value;
            newTransp.Transport.MaxSpeed = (int)Contr.Input[4].Value;

            repo.Update(id, newTransp);

            return true;
        }

        private ITransport GetNewTransportById(int id)
        {
            switch (id)
            {
                case 0:
                    return new Bicycle("", 1, 1, 1, 1, 1);
                case 1:
                    return new Bus("", 1, 1, 1, 1, 1);
                case 2:
                    return new Car("", 1, 1, 1, 1, 1);
                case 3:
                    return new Loader("", 1, 1, 1, 1, 1);
                case 4:
                    return new Motorcycle("", 1, 1, 1, 1, 1);
                case 5:
                    return new Scooter("", 1, 1, 1, 1, 1);
                case 6:
                    return new Tank("", 1, 1, 1, 1, 1);
                case 7:
                    return new Tram("", 1, 1, 1, 1, 1);
                case 8:
                    return new Trolley("", 1, 1, 1, 1, 1);
                case 9:
                    return new Cart("", 1, 1, 1, 1, 1);
                default:
                    return null;
            }
        }

        public bool PlaceTransport()
        {
            if (!IsAllSelected())
            {
                Contr.ShowMessage("Не все транспорты установлены и настроены.");
                return false;
            }

            for (var i = 0; i < 5; i++)
            {
                roadRepo.Find(i).RoadPeaces[0] = roadRepo.Find(i).TransportTemplate;

                repo.SetFullStamina(i);
            }

            Contr.ShowMessage("Транспорт установлен.");
            return true;
        }

        private bool IsAllSelected()
        {
            var transpData = repo.FindAll();

            foreach (var t in transpData)
            {
                if (t.Transport == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
