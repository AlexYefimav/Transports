using System;
using System.Windows.Forms;

using Transports.Forms;
using Transports.Code.Presenter;

namespace Transports.Code.View
{
    class MainController : IMainController
    {
        Main form;
        IMainService serv;

        Timer timer;

        public MainController(IMainService serv)
        {
            this.serv = serv;

            timer = new Timer();

            timer.Interval = 1000;
            timer.Tick += CountSeconds;
            timer.Enabled = true;
        }

        public void Init(Main form)
        {
            this.form = form;
        }

        private void CountSeconds(object sender, EventArgs e)
        {
            serv.IncWorkTime();
            PrintSB();
        }

        private void PrintSB()
        {
            var sb = $"Время работы: {serv.WorkTime}, движущихся ТС: {serv.TSCount}, время движения: {serv.MovingTime}, время простоя: {serv.StopTime}";

            form.SB.Text = sb;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
