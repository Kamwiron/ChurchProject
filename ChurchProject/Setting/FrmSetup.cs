using ChurchProject.Data;
using ChurchProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChurchProject.Setting
{
    public partial class FrmSetup : Form
    {
        private AttendanceRepository _attandanceRepo;
        private MaritalStatusRepository _maritalstatus;
        private ZoneRepository _zoneRepo;
        private OccupationRepository _occupation;
        private AttendanceTypeRepository _attendancetypeRepo;
        private MembershipStatusRepository _membershipstatusRepo;
        private MemberTypeRepository _membertypeRepo;
        private ZoneDetailRepository _zonedetailRepo;
        private ZoneHeadRepository _zoneheadRepo;
        private TownRepository _townRepo;
        private TitleRepository _TitleRepo;

        public FrmSetup()
        {
            InitializeComponent();
          _attandanceRepo = new AttendanceRepository();
            dataGridViewAttendance.DataSource = _attandanceRepo.GetAttendances();

            _maritalstatus = new MaritalStatusRepository();
            dataGridViewMarital.DataSource = _maritalstatus.GetMaritalStatuss();

            _zoneRepo = new ZoneRepository();
            dataGridViewZone.DataSource = _zoneRepo.GetZone();

            _occupation = new OccupationRepository();
            dataGridViewOccupation.DataSource = _occupation.GetOccupations();

            _attendancetypeRepo = new AttendanceTypeRepository();
            dataGridViewAttendanceType.DataSource = _attendancetypeRepo.GetAttendancesTypes();

            _membershipstatusRepo = new MembershipStatusRepository();
            dataGridViewMembership.DataSource = _membershipstatusRepo.GetMembershipStatus();

            _membertypeRepo = new MemberTypeRepository();
            dataGridViewMemberType.DataSource = _membertypeRepo.GetMemberTypes();

            _zonedetailRepo = new ZoneDetailRepository();
            dataGridViewZoneDetail.DataSource = _zonedetailRepo.GetZoneDetails();

            
            _zoneheadRepo = new ZoneHeadRepository();
            dataGridViewZoneHead.DataSource = _zoneheadRepo.GetZoneHeads();

            _TitleRepo = new TitleRepository();
            dataGridViewTitle.DataSource = _TitleRepo.GetTitles();

            _townRepo = new TownRepository();
            dataGridViewTown.DataSource = _townRepo.GetTowns();

        }
       
    }
}
