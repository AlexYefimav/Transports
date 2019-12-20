using System.Collections.Generic;

using Transports.Code.View;


namespace Transports.Code.Presenter
{
    interface IRoadService
    {
        IRoadController Contr { get; set; }

        void Init(RoadForm form);
        void Start();
        void Pause();
        void Continue();
        IRoad GetRoad(int id);
        IList<IRoad> GetRoads();
        IList<int> GetMovableRoad();
        void SetRoadType(int id);
        void MoveTransport(int roadId, int newId);

        ITransportData GetTransport(int id);
        void ShowLog(int id);
        void SetTSCount();
    }
}
