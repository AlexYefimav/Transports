using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Transports.Code.View
{
    interface ITransportController
    {
        TextBox Model { get; set; }
        IList<NumericUpDown> Input { get; set; }

        void Init(SelectTransport form);
        void LoadTransport(object sender, EventArgs e);
        void ClearTransportData();
        void LoadTransportType(int id);
        void LoadTransportData(int id);
        void LoadTransportData(ITransportData transportData);
        void SetTransportType(object sender, EventArgs e);
        int? GetSelectedTransport();
        int? GetSelectedTransportType();
        void UpdateStatusBar(SelectTransport form);

        void ShowMessage(string message);
    }
}
