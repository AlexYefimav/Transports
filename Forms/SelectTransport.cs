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
    public partial class SelectTransport : Form
    {
        readonly Service serv;

        public SelectTransport(object serv)
        {
            this.serv = serv as Service;
            InitializeComponent();
        }

        private void FuelTypeBtn_Click(object sender, EventArgs e)
        {
            if (serv.TransportService.PlaceTransport())
            {
                Hide();
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            serv.TransportService.SaveData(this);
        }
    }
}
