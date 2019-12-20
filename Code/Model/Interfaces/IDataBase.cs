using System.Collections.Generic;

namespace Transports.Code.Model
{
    interface IDataBase
    {
        IList<ITransportData> Transports { get; }
        IList<IFuel> Fuels { get; set; }
        IList<IRoad> Roads { get; }
    }
}
