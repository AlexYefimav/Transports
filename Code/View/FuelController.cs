using System.Collections.Generic;
using System.Windows.Forms;

using Transports.Code.Presenter;

namespace Transports.Code.View
{
    class FuelController : IFuelController
    {
        IFuelService serv;

        public FuelController(IFuelService serv)
        {
            this.serv = serv;
        }

        public IList<IFuel> GetFuelList(SelectFuel form)
        {
            var items = form.fuelTypeList.CheckedIndices;

            var accepted = new List<IFuel>();

            foreach (var i in items)
            {
                var fuel = new Fuel();
                fuel.Type = (FuelType)i;
                accepted.Add(fuel);
            }

            return accepted;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
