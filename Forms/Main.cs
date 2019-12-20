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

namespace Transports.Forms
{
    public partial class Main : Form
    {
        Service serv;

        public Main()
        {
            InitializeComponent();

            serv = new Service();
            serv.MainService.Init(this);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;

            var selectFuelForm = new SelectFuel(serv);

            selectFuelForm.FormClosed += OnStart;
            selectFuelForm.Show();
        }

        private void OnStart(object sender, EventArgs e)
        {
            start.Enabled = true;
        }

        private void SB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
