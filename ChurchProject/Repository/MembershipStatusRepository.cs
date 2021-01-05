using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class MembershipStatusRepository
    {
        private ChurchProjectEntities _context;
        public MembershipStatusRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<MembershipStatu> GetMembershipStatus()
        {
            var membershipstatus = _context.MembershipStatus.ToList();
            return membershipstatus;
        }
    }
}
