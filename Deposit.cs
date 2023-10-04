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
    public partial class Deposit : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        int AccNumbear;
        public Deposit()
        {
            InitializeComponent();

            string myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            conn = new SqlConnection(myConString);
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankCrystalReportDataSet4.Deposit' table. You can move, or remove it, as needed.
            this.depositTableAdapter.Fill(this.bankCrystalReportDataSet4.Deposit);

        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                string sqlQurey = "INSERT INTO csa.Deposit VALUES(@check,@begbal,@debal,@endbal,@clientid,@branchid)";
                cmd = new SqlCommand(sqlQurey, conn);

                cmd.Parameters.AddWithValue("@check", comboBox1AccCheck.Text);
                cmd.Parameters.AddWithValue("@begbal", textBox1BegBal.Text);
                cmd.Parameters.AddWithValue("@debal", textBox2DeBal.Text);
                cmd.Parameters.AddWithValue("@endbal", textBox3EndBal.Text); 
                cmd.Parameters.AddWithValue("@clientid", textBox4Clientid.Text);
                cmd.Parameters.AddWithValue("@branchid", textBox5Brnchid.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert Successfully..");
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttbgotohome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hm = new HomePage();   
            hm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AccNumbear = Convert.ToInt32(dataGridView1Deposit.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1AccCheck.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1BegBal.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2DeBal.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3EndBal.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4Clientid.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5Brnchid.Text = dataGridView1Deposit.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
     
        private void button3Branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranceOfBank branceOfBank = new BranceOfBank();
            branceOfBank.ShowDialog();
        }

        private void button1Client_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientTable clientTable = new ClientTable();
            clientTable.ShowDialog();
        }

        private void button4Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdraw wit = new withdraw();
            wit.ShowDialog();
        }

        private void bttnX_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
