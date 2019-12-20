using System;
using System.Collections.Generic;

namespace Transports.Code.View
{
    interface IRoadController
    {
        void Init(RoadForm form);

        void Start(IList<int> movableRoad);
        void Pause(IList<int> movableRoad);
        void Continue(IList<int> movableRoad);

        int GetSelectedIndex(int id);

        void ShowMessage(string message);
    }
}
