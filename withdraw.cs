using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCReport
{
    public partial class withdraw : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;

        public withdraw()
        {
            InitializeComponent();

            string myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            conn = new SqlConnection(myConString);

        }

        private void withdraw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankCrystalReportDataSet5.Withdraw' table. You can move, or remove it, as needed.
            this.withdrawTableAdapter.Fill(this.bankCrystalReportDataSet5.Withdraw);
           
        }

        private void bttnGotoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1WitAmount.Text != "" && textBox2AccNo.Text != "")
                {
                    conn.Open();

                    string SqlQuery = "Insert into csa.Withdraw Values(@withamount, @accounno)";
                    SqlCommand cmd = new SqlCommand(SqlQuery, conn);

                    cmd.Parameters.AddWithValue("@withamount", textBox1WitAmount.Text);
                    cmd.Parameters.AddWithValue("@accounno", textBox2AccNo.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Insert Successfully Your data.. ");
                }
                else
                {
                    MessageBox.Show("Input data Wrong.. ");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Try again.. " + ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            this.withdrawTableAdapter.Fill(this.bankCrystalReportDataSet5.Withdraw);
            adapter = new SqlDataAdapter("select * from csa.Withdraw", conn);
            ds = new System.Data.DataSet();
            adapter.Fill(ds);
            dataGridView1Witdraw.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
