using Transports.Forms;
using Transports.Code.View;


namespace Transports.Code.Presenter
{
    interface IMainService
    {
        IMainController Contr { get; set; }
        int WorkTime { get; set; }
        int MovingTime { get; set; }
        int StopTime { get; set; }
        int TSCount { get; set; } 

        void Init(Main form);
        void IncWorkTime();
        void IncMovingTime();
        void IncStopTime();
    }
}
