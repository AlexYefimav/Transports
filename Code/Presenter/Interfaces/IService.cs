using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.Code.Presenter
{
    interface IService
    {
        IFuelService FuelService { get; }
        ITransportService TransportService { get; }
        IRoadService RoadService { get; }
        IMainService MainService { get; }
    }
}
