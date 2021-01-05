using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    public class ZoneDetailRepository
    {
        private ChurchProjectEntities _context;
        public ZoneDetailRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<ZoneDetail> GetZoneDetails()
        {
            var zonedetail = _context.ZoneDetails.ToList();
            return zonedetail;
        }
    }
}
