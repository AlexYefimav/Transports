using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.Code.Model
{
    interface ITransportRepository : IRepository<ITransportData>
    {
        void SetTransportType(int id, int value);
        void SetFullStamina(int id);
        void AddLogs(int id, string message);
    }
}
