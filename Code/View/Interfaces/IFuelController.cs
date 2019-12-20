using System.Collections.Generic;

namespace Transports.Code.View
{
    interface IFuelController
    {
        IList<IFuel> GetFuelList(SelectFuel form);

        void ShowMessage(string message);
    }
}
