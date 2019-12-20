using System.Collections.Generic;
using Transports.Code.View;

namespace Transports.Code.Presenter
{
    interface ITransportService
    {
        ITransportController Contr { get; set; }

        void Init(SelectTransport form);
        bool SetTransportType(int id, int value);
        ITransportData GetTransport(int id);
        IList<IFuel> GetFuelsList();
        IFuel GetFuel(int id);
        void SaveData(SelectTransport form);
        bool UpdateData(int id);
        bool PlaceTransport();
    }
}
