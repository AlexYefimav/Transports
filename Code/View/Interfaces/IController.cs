namespace Transports.Code.View
{
    interface IController
    {
        IFuelController FuelController { get; }
        ITransportController TransportController { get; }
        IRoadController RoadController { get; }
        IMainController MainController { get; }

        void ShowMessage(string message);
    }
}
