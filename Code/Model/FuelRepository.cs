using System.Collections.Generic;

namespace Transports.Code.Model
{
    class FuelRepository : IFuelRepository
    {
        IList<IFuel> fuels;
        private int id = 0;

        public FuelRepository(IList<IFuel> fuels)
        {
            this.fuels = fuels;
            this.fuels.Clear();
        }

        public void Add(IFuel obj)
        {
            obj.Id = id++;
            fuels.Add(obj);
        }

        public IFuel Find(int id)
        {
            foreach (var f in fuels)
            {
                if (f.Id == id)
                {
                    return f;
                }
            }

            return null;
        }

        public IList<IFuel> FindAll()
        {
            return fuels;
        }

        public void Remove(int id)
        {
            fuels.Remove(Find(id));
        }

        public void Update(int id, IFuel obj)
        {
            obj.Id = id;
            fuels[id] = obj;
        }

        public void SetFuelList(IList<IFuel> fuels)
        {
            var newFuel = new List<IFuel>();

            foreach(var f in fuels)
            {
                f.Id = id++;
                newFuel.Add(f);
            }

            this.fuels = newFuel;
        }
    }
}
