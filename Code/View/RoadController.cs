using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Transports.Code.Presenter;

namespace Transports.Code.View
{
    class RoadController : IRoadController
    {
        IEnumerable<int> movableRoad;

        readonly IRoadService serv;
        readonly IController contr;

        readonly ITransportService tServ;

        RoadForm form;

        readonly IList<TextBox> roads;
        readonly IList<ComboBox> types;

        readonly Timer timer = null;
        readonly Timer moveTimer = null;

        readonly string[] typeValues = { "Рельсы", "Дорога", "Полоса", "Провода" };

        public RoadController(IController contr, IRoadService serv, ITransportService tServ)
        {
            this.contr = contr;
            this.serv = serv;
            this.tServ = tServ;

            roads = new List<TextBox>();
            types = new List<ComboBox>();

            timer = new Timer
            {
                Interval = 1000
            };

            moveTimer = new Timer
            {
                Interval = 1000
            };
        }

        public void Init(RoadForm form)
        {
            this.form = form;

            roads.Clear();
            types.Clear();

            roads.Add(form.one);
            roads.Add(form.two);
            roads.Add(form.three);
            roads.Add(form.four);
            roads.Add(form.five);

            types.Add(form.oneType);
            types.Add(form.twoType);
            types.Add(form.threeType);
            types.Add(form.fourType);
            types.Add(form.fiveType);

            timer.Tick += Update;
            timer.Enabled = true;

            foreach (var t in types)
            {
                t.Items.AddRange(typeValues);
                t.SelectedIndex = 1;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            var currentRoads = serv.GetRoads();

            for (var i = 0; i < roads.Count; i++)
            {
                currentRoads[i].CurrentRoad = currentRoads[i].ToString();
                roads[i].Text = currentRoads[i].CurrentRoad;

                if (!form.start.Enabled)
                {
                    if (roads[i].Text.Contains(currentRoads[i].TransportTemplate))
                    {
                        form.logs.Enabled = true;
                        form.start.Enabled = true;
                        form.stop.Enabled = true;
                    }
                }
            }

            serv.SetTSCount();
        }

        public int GetSelectedIndex(int id)
        {
            return types[id].SelectedIndex;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void Start(IList<int> movableRoad)
        {
            this.movableRoad = movableRoad;
            
            foreach (var r in this.movableRoad)
            {
                tServ.GetTransport(r).Transport.StartMoving();

                moveTimer.Tick += (x, y) =>
                {
                    if (!tServ.GetTransport(r).Transport.isMoving)
                    {
                        return;
                    }

                    if (tServ.GetTransport(r).Transport.CurrentStamina == 0 || serv.GetRoad(r).XPos >= 50)
                    {
                        tServ.GetTransport(r).Transport.StopMoving();

                        return;
                    }

                    serv.MoveTransport(r, tServ.GetTransport(r).Transport.CurrentSpeed);
                };
            }

            moveTimer.Enabled = true;
        }

        public void Pause(IList<int> movableRoad)
        {
            foreach (var r in movableRoad)
            {
                tServ.GetTransport(r).Transport.StopMoving();
            }
        }

        public void Continue(IList<int> movableRoad)
        {
            foreach (var r in movableRoad)
            {
                tServ.GetTransport(r).Transport.StartMoving();
            }
        }
        
    }
}
