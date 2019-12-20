using Transports.Code.Libs;

namespace Transports.Code
{
    class TransportData : ITransportData
    {
        public int Id { get; set; }
        public int? Type { get; set; } = null;

        public ITransport Transport { get; set; }
    }
}
