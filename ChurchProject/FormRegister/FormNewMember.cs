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

namespace ChurchProject.FormRegister
{
    public partial class FormNewMember : Form
    {
        private MemberRepository _memberRepo;

        public FormNewMember()
        {
            InitializeComponent();
        }

        public FormNewMember(int memberId)
        {

            InitializeComponent();
            _memberRepo = new MemberRepository();
            var memberselection = _memberRepo.GetMember(memberId);

            textBoxFirstName.Text = memberselection.FirstName;
            textBoxLastName.Text = memberselection.FirstName;
            textBoxOtherName.Text = memberselection.OtherName;
            textBoxPrefferredName.Text = memberselection.PrefferedName;
            textBoxSpouseName.Text = memberselection.SpouseName;
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            var AddChild = new FrmMemberChild();
            AddChild.ShowDialog();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
