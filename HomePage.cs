using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCReport
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void bttnHomeExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
          
        }

        private void button1Branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranceOfBank branceOfBank = new BranceOfBank();
            branceOfBank.ShowDialog();
        }

        private void button2Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientTable clientTable = new ClientTable();
            clientTable.ShowDialog();
        }

        private void button3Deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }

        private void button4Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdraw wit = new withdraw();
            wit.ShowDialog();
        }

        private void bttnCrystalR_Click(object sender, EventArgs e)
        {
            this.Show();
            BankCrystalR01 bankCrystalR01 = new BankCrystalR01();
            bankCrystalR01.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
