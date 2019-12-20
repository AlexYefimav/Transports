using System.Windows.Forms;

using Transports.Code.Presenter;

namespace Transports.Code.View
{
    partial class Controller : IController
    {
        public IFuelController FuelController { get; }
        public ITransportController TransportController { get; }
        public IRoadController RoadController { get; }
        public IMainController MainController { get; }

        public Controller(Service serv)
        {
            FuelController = new FuelController(serv.FuelService);
            TransportController = new TransportController(serv.TransportService);
            RoadController = new RoadController(this, serv.RoadService, serv.TransportService);
            MainController = new MainController(serv.MainService);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
