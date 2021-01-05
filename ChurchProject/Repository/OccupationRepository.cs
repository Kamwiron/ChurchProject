using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class OccupationRepository
    {
        private ChurchProjectEntities _context;
        public OccupationRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<Occupation> GetOccupations()
        {
            var Occupation = _context.Occupations.ToList();
            return Occupation;
        }
    }
}
