using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
   public class MemberZoneDetailsRepository
    {
        private ChurchProjectEntities _context;
        public MemberZoneDetailsRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<MemberZoneDetail> GetMemberZoneDetails()
        {
            var memberzonedetails = _context.MemberZoneDetails.ToList();
            return memberzonedetails;
        }
    }
}
