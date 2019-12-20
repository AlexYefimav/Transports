using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transports.Code.Model;
using Transports.Code.View;

namespace Transports.Code.Presenter
{
    partial class Service : IService
    {
        readonly Repository repo;
        readonly IController contr;

        public IFuelService FuelService { get; }
        public ITransportService TransportService { get; }
        public IRoadService RoadService { get; }
        public IMainService MainService { get; }

        public Service()
        {
            repo = new Repository();

            FuelService = new FuelService(repo.FuelsRepository, null);
            TransportService = new TransportService(repo.TransportsRepositoty, null, repo.FuelsRepository, repo.RoadRepository);
            MainService = new MainService(null);
            RoadService = new RoadService(repo.RoadRepository, null, repo.TransportsRepositoty, MainService);

            contr = new Controller(this);

            FuelService.Contr = contr.FuelController;
            TransportService.Contr = contr.TransportController;
            RoadService.Contr = contr.RoadController;
            MainService.Contr = contr.MainController;
        }
    }
}
