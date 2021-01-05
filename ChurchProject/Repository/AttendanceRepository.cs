using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace ChurchProject.Repository
{
    class AttendanceRepository
    {
        private ChurchProjectEntities _context;
        public AttendanceRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<Attendance> GetAttendances()
        {
            var attendance = _context.Attendances.ToList();
            return attendance;
        }


    }
}
