using System.Collections.Generic;

namespace Transports.Code.Model
{
    interface IFuelRepository : IRepository<IFuel>
    {
        void SetFuelList(IList<IFuel> fuels);
    }
}
