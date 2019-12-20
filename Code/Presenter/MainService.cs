using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Transports.Forms;
using Transports.Code.View;

namespace Transports.Code.Presenter
{
    class MainService : IMainService
    {
        public IMainController Contr { get; set; }

        public int WorkTime { get; set; } = 0;
        public int MovingTime { get; set; } = 0;
        public int StopTime { get; set; } = 0;
        public int TSCount { get; set; } = 0;

        public MainService(IMainController contr)
        {
            Contr = contr;
        }

        public void Init(Main form)
        {
            Contr.Init(form);
        }

        public void IncWorkTime()
        {
            WorkTime++;
        }

        public void IncMovingTime()
        {
            MovingTime++;
        }

        public void IncStopTime()
        {
            StopTime++;
        }
    }
}
