using System;
using System.Collections.Generic;

namespace Transports.Code
{
    class Road : IRoad
    {
        public int Id { get; set; }
        public string CurrentRoad { get; set; }
        public MoveType MoveType { get; set; }

        public int XPos { get; set; } = 0;
        public string XTemp { get; set; } = "  0";

        public string TransportTemplate { get; } = "  X  ";
        public string TransportStationTemplate { get; } = "  З  ";

        public IList<string> RoadPeaces { get; } = new List<string>(500 / 10 + 1);

        private const int stopCount = 5;

        public void StartString(Random sead)
        {
            RoadPeaces.Add("0");

            for (int i = 1; i <= (500 / 10); i++)
            {
                if (i % (100 / 10) == 0)
                {
                    RoadPeaces.Add("  " + (i * 10) + " ");
                }
                else
                {
                    RoadPeaces.Add(" _");
                }
            }

            for (var i = 0; i < stopCount; i++)
            {
                var id = (sead.Next() % (500 / 10)) + 1;
                RoadPeaces[id] = TransportStationTemplate;
            }

        }

        public override string ToString()
        {
            var result = "";

            foreach (var r in RoadPeaces)
            {
                result += r;
            }

            return result;
        }
    }
}
