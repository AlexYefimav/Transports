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
    public partial class RoadForm : Form
    {
        readonly Service serv;

        public RoadForm(object serv)
        {
            this.serv = serv as Service;
            InitializeComponent();
        }

        private void OneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            serv.RoadService.SetRoadType(0);
        }

        private void TwoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            serv.RoadService.SetRoadType(1);
        }

        private void ThreeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            serv.RoadService.SetRoadType(2);
        }

        private void FourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            serv.RoadService.SetRoadType(3);
        }

        private void FiveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            serv.RoadService.SetRoadType(4);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (type.Enabled)
            {
                serv.RoadService.Start();
            }
            else
            {
                serv.RoadService.Continue();
            }

            type.Enabled = false;
            start.Enabled = false;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            start.Enabled = true;
            serv.RoadService.Pause();
        }

        private void Road1_Click(object sender, EventArgs e)
        {
            serv.RoadService.ShowLog(0);
        }

        private void Road2_Click(object sender, EventArgs e)
        {
            serv.RoadService.ShowLog(1);
        }

        private void Road3_Click(object sender, EventArgs e)
        {
            serv.RoadService.ShowLog(2);
        }

        private void Road4_Click(object sender, EventArgs e)
        {
            serv.RoadService.ShowLog(3);
        }

        private void Road5_Click(object sender, EventArgs e)
        {
            serv.RoadService.ShowLog(4);
        }
    }
}
