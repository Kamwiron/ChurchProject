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

namespace ChurchProject.LogIn
{
    public partial class FormSignInAndUp : Form
    {
        public FormSignInAndUp()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSignIn(object sender, EventArgs e)
        {
            var SignIn = new FormNewMember();
            SignIn.ShowDialog();
        }

        private void ButtonCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSignUp(object sender, EventArgs e)
        {
            var SignIn = new FormSignInAndUp();
            SignIn.ShowDialog();
        }

        private void ButtonClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
