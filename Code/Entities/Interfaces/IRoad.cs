using System;
using System.Collections.Generic;

namespace Transports.Code
{
    interface IRoad : IEntity
    {
        string CurrentRoad { get; set; }
        MoveType MoveType { get; set; }
        int XPos { get; set; }
        string XTemp { get; set; }
        string TransportTemplate { get; }
        string TransportStationTemplate { get; }
        IList<string> RoadPeaces { get; }
        void StartString(Random sead);
    }
}
