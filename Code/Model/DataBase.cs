using System.Collections.Generic;

namespace Transports.Code.Model
{
    class DataBase : IDataBase
    {
        public IList<ITransportData> Transports { get; }
        public IList<IFuel> Fuels { get; set; }
        public IList<IRoad> Roads { get; }

        public DataBase()
        {
            Transports = new List<ITransportData>();
            Fuels = new List<IFuel>();
            Roads = new List<IRoad>();
        }
    }
}
