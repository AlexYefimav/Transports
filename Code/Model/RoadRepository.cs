using System;
using System.Collections.Generic;

namespace Transports.Code.Model
{
    class RoadRepository : IRoadRepository 
    {
        readonly IList<IRoad> roads;
        private int id = 0;
        private const int roadMax = 5;

        public RoadRepository(IList<IRoad> roads)
        {
            this.roads = roads as List<IRoad>;

            this.roads.Clear();

            var rand = new Random();
            for (var i = 0; i < roadMax; i++)
            {
                var road = new Road();

                road.StartString(rand);

                road.CurrentRoad = road.ToString();
                Add(road);
            }
        }

        public void Add(IRoad obj)
        {
            obj.Id = id++;
            roads.Add(obj);
        }

        public IRoad Find(int id)
        {
            foreach (var r in roads)
            {
                if (r.Id == id)
                {
                    return r;
                }
            }

            return null;
        }

        public IList<IRoad> FindAll()
        {
            return roads;
        }

        public void Remove(int id)
        {
            roads.Remove(Find(id));
        }

        public void Update(int id, IRoad obj)
        {
            obj.Id = id;
            roads[id] = obj;
        }
    }
}
