using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Transports.Code.Presenter;

namespace Transports.Code.View
{
    class TransportController : ITransportController
    {
        ITransportService serv;

        RadioButton[] transport;
        RadioButton[] transportType;

        public TextBox Model { get; set; }
        public IList<NumericUpDown> Input { get; set; }

        public TransportController(ITransportService serv)
        {
            this.serv = serv;
        }

        public void Init(SelectTransport form)
        {
            transport = new RadioButton[]
            {
                form.transpOne,
                form.transpTwo,
                form.transpThree,
                form.transpFour,
                form.transpFive
            };

            transportType = new RadioButton[]
            {
                form.vel,
                form.bus,
                form.car,
                form.loa,
                form.mot,
                form.sco,
                form.tan,
                form.tra,
                form.tro,
                form.cart
            };

            Model = form.model;

            Input = new NumericUpDown[]
            {
                form.passangerCount,
                form.ownerAge,
                form.stamina,
                form.startSpeed,
                form.maxSpeed
            };

            foreach (var t in transport)
            {
                t.Click += LoadTransport;
            }

            foreach (var t in transportType)
            {
                t.Click += SetTransportType;
            }
        }

        public void LoadTransport(object sender, EventArgs e)
        {
            var id = int.Parse((sender as RadioButton).Text.Split(' ')[0]) - 1;

            ClearTransportData();
            LoadTransportType(id);
            LoadTransportData(id);
        }

        public void ClearTransportData()
        {
            Model.Text = "";

            foreach (var i in Input)
            {
                i.Value = 1;
            }
        }

        public void LoadTransportType(int id)
        {
            var info = serv.GetTransport(id);

            if (info.Type == null)
            {
                var typeId = GetSelectedTransportType();
                if (typeId == null)
                {
                    return;
                }

                transportType[typeId.Value].Checked = false;
                return;
            }

            transportType[info.Type.Value].Select();
            LoadTransportData(info);
        }

        public void LoadTransportData(int id)
        {
            var transport = serv.GetTransport(id);
            if (transport.Transport == null)
            {
                return;
            }

            var model = transport.Transport.Model;
            Model.Text = model;
        }

        public void LoadTransportData(ITransportData transportData)
        {
            Model.Text = transportData.Transport.Model;
            Input[0].Value = transportData.Transport.PassangersCount;
            Input[1].Value = transportData.Transport.OwnerAge;
            Input[2].Value = transportData.Transport.Stamina;
            Input[3].Value = transportData.Transport.StartSpeed;
            Input[4].Value = transportData.Transport.MaxSpeed;
        }

        public void SetTransportType(object sender, EventArgs e)
        {
            var typeId = int.Parse((sender as RadioButton).Text.Split(' ')[0]) - 1;

            var transportId = GetSelectedTransport();

            if (transportId == null)
            {
                (sender as RadioButton).Checked = false;
                ShowMessage("Выберете транспорт!");
                return;
            }

            if (!serv.SetTransportType(transportId.Value, typeId))
            {
                (sender as RadioButton).Checked = false;
                ShowMessage("Нет необходимого топлива для этого транспорта!");
                return;
            }
        }

        public int? GetSelectedTransport()
        {
            for (var i = 0; i < transport.Length; i++)
            {
                if (transport[i].Checked)
                {
                    return i;
                }
            }

            return null;
        }

        public int? GetSelectedTransportType()
        {
            for (var i = 0; i < transportType.Length; i++)
            {
                if (transportType[i].Checked)
                {
                    return i;
                }
            }

            return null;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void UpdateStatusBar(SelectTransport form)
        {
            var fuelList = serv.GetFuelsList();
            var text = "Топливо:";

            foreach (var f in fuelList)
            {
                switch (f.Type.ToString())
                {
                    case "Diesel":
                        text += " Дизель";
                        break;
                    case "Energy":
                        text += " Энергия";
                        break;
                    case "Gas":
                        text += " Газ";
                        break;
                    case "Petrol":
                        text += " Бензин";
                        break;
                }
            }

            form.sb.Text = text;
        }
    }
}
