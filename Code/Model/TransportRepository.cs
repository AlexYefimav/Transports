using System.Collections.Generic;

namespace Transports.Code.Model
{
    class TransportRepository : ITransportRepository
    {
        readonly IList<ITransportData> transports;
        private int id = 0;
        private const int transportCount = 5;

        public TransportRepository(IList<ITransportData> transports)
        {
            this.transports = transports as List<ITransportData>;

            this.transports.Clear();

            for (var i = 0; i < transportCount; i++)
            {
                Add(new TransportData());
            }
        }

        public void Add(ITransportData transport)
        {
            transport.Id = id++;
            transports.Add(transport);
        }

        public void Update(int id, ITransportData transport)
        {
            transport.Id = id;
            transports[id] = transport;
        }

        public void Remove(int id)
        {
            transports.Remove(Find(id));
        }

        public ITransportData Find(int id)
        {
            foreach (var t in transports)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }

            return null;
        }

        public IList<ITransportData> FindAll()
        {
            return transports;
        }

        public void SetTransportType(int id, int value)
        {
            Find(id).Type = value;
        }

        public void SetFullStamina(int id)
        {
            Find(id).Transport.CurrentStamina = Find(id).Transport.Stamina;
        }

        public void AddLogs(int id, string message)
        {
            Find(id).Transport.Log += Find(id).Transport.LogTemplate(message);
        }
    }
}
