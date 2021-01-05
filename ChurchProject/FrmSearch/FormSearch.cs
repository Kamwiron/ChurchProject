using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChurchProject.FormRegister;
using ChurchProject.Repository;

namespace ChurchProject.FrmSearch
{
    public partial class FormSearch : Form
    {
        private MemberRepository _memberRepo;

        public FormSearch()
        {
            InitializeComponent();
            _memberRepo = new MemberRepository();
            dataGridViewFormSearch.DataSource = _memberRepo.GetMembers();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var memberSelection = dataGridViewFormSearch.SelectedRows[0];
            var PrefferedColumn = Convert.ToInt32(memberSelection.Cells["MemberId"].Value);

            var Edit = new FormNewMember();
            Edit.ShowDialog();
        }
    }
}
