using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace BankCReport
{
    public partial class BranceOfBank : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        int branch_id;
        public BranceOfBank()
        {
            InitializeComponent();
           

            string myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            conn = new SqlConnection(myConString);
        }

        private void button2AddBranch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1BranceName.Text !="" && textBox2BranchEmail.Text !="")
                {

                    //conn.Open();
                    //cmd = new SqlCommand();
                    //cmd.CommandText = "sp_Bramch";
                    //cmd.Connection = conn;
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("@brancName", textBox1BranceName.Text);
                    //cmd.Parameters.AddWithValue("@brancemail", textBox2BranchEmail.Text);
                    //cmd.Parameters.AddWithValue("@brancphone", textBox3Phone.Text);

                    //cmd.ExecuteNonQuery();
                    //conn.Close();
                    //MessageBox.Show("Insert Successfully..");


                    conn.Open();

                    string sqlQurey = "INSERT INTO csa.BranchOfBank VALUES(@name,@email,@phone)";
                    cmd = new SqlCommand(sqlQurey, conn);

                    cmd.Parameters.AddWithValue("@name", textBox1BranceName.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2BranchEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox3Phone.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Insert Successfully..");
                    Clear();

                }
                else
                {
                    MessageBox.Show("Wrong Your Insert..");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Input Wrong Try Again.."+ex.Message);
            }
        }
       
        

        private void BranceOfBank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankCrystalReportDataSet3.BranchOfBank' table. You can move, or remove it, as needed.
            this.branchOfBankTableAdapter1.Fill(this.bankCrystalReportDataSet3.BranchOfBank);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hom = new HomePage();
            hom.ShowDialog();
        }

        private void bttnShow_Click(object sender, EventArgs e)
        {
            this.branchOfBankTableAdapter1.Fill(this.bankCrystalReportDataSet3.BranchOfBank);
            adapter = new SqlDataAdapter("select * from csa.BranchOfBank",conn);
            ds = new System.Data.DataSet();
            adapter.Fill(ds);
            dataGridViewBranch.DataSource = ds.Tables[0].DefaultView;

            //adapter = new SqlDataAdapter("Select * from BranceOfBank", conn);
            //ds = new System.Data.DataSet();
            //adapter.Fill(ds);
            //dataGridViewBranch.DataSource = ds.Tables[0].DefaultView;


        }
        public void Clear()
        {
            textBox1BranceName.Text = "";
            textBox2BranchEmail.Text = "";
            textBox3Phone.Text = "";  

        }

        private void dataGridViewBranch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            branch_id = Convert.ToInt32(dataGridViewBranch.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1BranceName.Text = dataGridViewBranch.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2BranchEmail.Text = dataGridViewBranch.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3Phone.Text = dataGridViewBranch.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("update csa.BranchOfBank set BranchName = '" + textBox1BranceName.Text + "', BranchEmail='" + textBox2BranchEmail.Text + "', BranchPhoneNo='" + textBox3Phone.Text + "' where BranchID='" + branch_id + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data update successfully..");
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Try again update..  " + ex.Message);
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("delete from csa.BranchOfBank where BranchID='"+ branch_id + "'",conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Date Successful.. ");
            conn.Close();

        }

        private void dataGridViewBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
