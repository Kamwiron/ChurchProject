using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class MemberTypeRepository
    {
        private ChurchProjectEntities _context;
        public MemberTypeRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<MemberType> GetMemberTypes()
        {
            var membertype = _context.MemberTypes.ToList();
            return membertype;
        }
    }
}
