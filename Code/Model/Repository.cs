namespace Transports.Code.Model
{
    class Repository
    {
        readonly IDataBase db;

        public ITransportRepository TransportsRepositoty { get; }
        public IFuelRepository FuelsRepository { get; }
        public IRoadRepository RoadRepository { get; }

        public Repository()
        {
            db = new DataBase();

            TransportsRepositoty = new TransportRepository(db.Transports);
            FuelsRepository = new FuelRepository(db.Fuels);
            RoadRepository = new RoadRepository(db.Roads);
        }
    }
}
