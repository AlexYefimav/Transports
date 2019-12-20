using Transports.Code.Libs;

namespace Transports.Code
{
    interface ITransportData : IEntity
    {
        int? Type { get; set; }
        ITransport Transport { get; set; }
    }
}
