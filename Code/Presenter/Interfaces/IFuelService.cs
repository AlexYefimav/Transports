using Transports.Code.View;

namespace Transports.Code.Presenter
{
    interface IFuelService
    {
        IFuelController Contr { get; set; }

        bool SetFuelList(SelectFuel form);
    }
}
