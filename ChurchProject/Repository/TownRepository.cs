using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    public class TownRepository
    {
        private ChurchProjectEntities _context;
        public TownRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<Town> GetTowns()
        {
            var town = _context.Towns.ToList();
            return town;
        }
    }
}
