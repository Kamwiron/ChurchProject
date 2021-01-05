using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class ZoneRepository
    {
        private  ChurchProjectEntities _context;   
        public ZoneRepository()
        {
            _context = new  ChurchProjectEntities();

        }
        public List<Zone> GetZone()
        {
          var zones = _context.Zones.ToList();
            return zones;
        }
      
        

    }
}
