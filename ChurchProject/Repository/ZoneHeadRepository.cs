using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    public class ZoneHeadRepository
    {
        private ChurchProjectEntities _context;
        public ZoneHeadRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<ZoneHead> GetZoneHeads()
        {
            var zonehead = _context.ZoneHeads.ToList();
            return zonehead;
        }
    }
}
