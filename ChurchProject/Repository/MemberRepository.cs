using ChurchProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChurchProject.Repository
{
   public class MemberRepository
    {
       private ChurchProjectEntities _context;
        public MemberRepository()
        {
            _context = new ChurchProjectEntities();
        }
        public List<Member> GetMembers()
        {
            var members = _context.Members.ToList();
            return members;
        }

        public Member GetMember(int memberId)
        {
            var member = _context.Members.First(a => a.MemberId == memberId);
            return member;
        }

      
    }
}
