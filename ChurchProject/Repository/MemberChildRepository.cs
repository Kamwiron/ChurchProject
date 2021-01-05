using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class MemberChildRepository
    {
        private ChurchProjectEntities _context;
        public MemberChildRepository()
        {
            _context = new ChurchProjectEntities();
        }
        public List<MemberChild> GetMemberChildren()
        {
            var memberchildren = _context.MemberChilds.ToList();
            return memberchildren;
        }



    }
}
