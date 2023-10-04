using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCReport
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text =="Yousof" && txtBoxPassword.Text == "Yousof@123")
            {
                this.Hide();
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Provide The Valid Information!!!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}
