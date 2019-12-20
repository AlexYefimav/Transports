using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transports.Code.Presenter;


namespace Transports
{
    public partial class SelectFuel : Form
    {
        Service serv;
        private SelectTransport stForm = null;
        private RoadForm rForm = null;

        public SelectFuel(object serv)
        {
            this.serv = serv as Service;
            InitializeComponent();

            FormClosed += Close;
        }

        private void FuelTypeBtn_Click(object sender, EventArgs e)
        {
            if (!serv.FuelService.SetFuelList(this))
            {
                return;
            }

            var selectTransport = new SelectTransport(serv);

            serv.TransportService.Init(selectTransport);

            selectTransport.Show();
            selectTransport.FormClosed += ShowForm;

            var road = new RoadForm(serv);
            road.FormClosed += ShowForm;


            serv.RoadService.Init(road);
            road.Show();

            stForm = selectTransport;
            rForm = road;

            fuelTypeBtn.Enabled = false;
            fuelType.Enabled = false;
        }

        private void ShowForm(object sender, EventArgs e)
        {
            fuelTypeBtn.Enabled = true;
            fuelType.Enabled = true;

            Close(sender, e);
        }

        private void Close(object sender, EventArgs e)
        {
            if (stForm != null)
            {
                var form = stForm;
                stForm = null;
                form.Close();
            }

            if (rForm != null)
            {
                var form = rForm;
                rForm = null;
                form.Close();
            }
        }
    }
}
