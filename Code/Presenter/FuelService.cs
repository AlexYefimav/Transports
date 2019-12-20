using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transports.Code.Model;
using Transports.Code.View;

namespace Transports.Code.Presenter
{
    class FuelService : IFuelService
    {
        readonly IFuelRepository repo;
        public IFuelController Contr { get; set; }

        public FuelService(IFuelRepository repo, IFuelController contr)
        {
            this.repo = repo;
            Contr = contr;
        }

        public bool SetFuelList(SelectFuel form)
        {
            var items = Contr.GetFuelList(form) as List<IFuel>;

            if (items.Count == 0)
            {
                Contr.ShowMessage("Ни одного топлива не выбрано!");
                return false;
            }

            repo.SetFuelList(items);

            Contr.ShowMessage("Топливо выбрано.");

            return true;
        }
    }
}
