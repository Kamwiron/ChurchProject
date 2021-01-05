using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChurchProject.FrmSearch;
using ChurchProject.FormRegister;
using ChurchProject.Setting;

namespace ChurchProject.FormDashBoard
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
        }

        private void SearchMemberButton_Click(object sender, EventArgs e)
        {
            var searchForm = new FormSearch();
            searchForm.ShowDialog();
        
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            var AddMember = new FormNewMember();
            AddMember.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want To Exit? ","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void ManageAccountButton_Click(object sender, EventArgs e)
        {
            var setup = new FrmSetup();
            setup.ShowDialog();
        }
    }
}
