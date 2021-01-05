using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class MaritalStatusRepository
    {


        public int Name { get; set; }
        private ChurchProjectEntities _context;
        public MaritalStatusRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<MaritalStatu> GetMaritalStatuss()
        {
            var maritalstatus = _context.MaritalStatus.ToList();
            return maritalstatus;
        }
    }
}
