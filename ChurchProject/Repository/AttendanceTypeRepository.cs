using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchProject.Data;

namespace ChurchProject.Repository
{
    class AttendanceTypeRepository
    {
        private ChurchProjectEntities _context;
        public AttendanceTypeRepository()
        {
            _context = new ChurchProjectEntities();
        }

        public List<AttendanceType> GetAttendancesTypes()
        {
            var attendancetype = _context.AttendanceTypes.ToList();
            return attendancetype;
        }
    }
}
