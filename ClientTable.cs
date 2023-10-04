using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace BankCReport
{
    public partial class ClientTable : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;       
        DataTable dt;           
        string gender;
        int client_id;
        public ClientTable()
        {
            InitializeComponent();

            String myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            conn = new SqlConnection(myConString);
          
        }


        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (radioButton1Male.Checked == true)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            try
            {

                if(textBox1CName.Text !="" && textBox2CAdd.Text != "")
                {
                
                    conn.Open();

                    string sqlQurey = "INSERT INTO csa.Clien VALUES(@cName,@cAddress,@cDOB,@cgender,@cphoto,@cbranchid)";
                    cmd = new SqlCommand(sqlQurey, conn);

                    cmd.Parameters.AddWithValue("@cName", textBox1CName.Text);
                    cmd.Parameters.AddWithValue("@cAddress", textBox2CAdd.Text);
                    cmd.Parameters.AddWithValue("@cDOB", DateTime.Parse(dateTimeClient.Text));
                    cmd.Parameters.AddWithValue("@cgender", gender);
                    cmd.Parameters.AddWithValue("@cphoto", Path.GetFileName(textBoxPhoto.Text));
                    cmd.Parameters.AddWithValue("@cbranchid", textBox3BrancID.Text);      

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Record Insert succesfuly..");
                    
                }
                else
                {
                    MessageBox.Show("Wrong your input..");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Try again......... "+ex.Message);
            }

            
        }

        private void ClientTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankCrystalReportDataSet2.Clien' table. You can move, or remove it, as needed.
            this.clienTableAdapter1.Fill(this.bankCrystalReportDataSet2.Clien);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            client_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1CName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2CAdd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimeClient.Text =dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPhoto.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3BrancID.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();


        }

        private void bttnCGotoHom_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
        }

        private void bttnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if ( open.ShowDialog()== DialogResult.OK)
            {
                string imagePath = open.FileName;
                pictureBox1Photo.Image = new Bitmap(imagePath);
                textBoxPhoto.Text = imagePath;

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string correctName = System.IO.Path.GetFileName(open.FileName);
                System.IO.File.Copy(open.FileName, path + "\\Photo\\"+ correctName);
            }
        }

        private void button1Refresh_Click(object sender, EventArgs e)
        {
            this.clienTableAdapter1.Fill(this.bankCrystalReportDataSet2.Clien);
            adapter = new SqlDataAdapter("select * from csa.Clien", conn);
            ds = new System.Data.DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource =ds.Tables[0].DefaultView;
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("update csa.Clien set CName = '" + textBox1CName.Text + "', CAddress='" + textBox2CAdd.Text + "', CDOB='" + DateTime.Parse(dateTimeClient.Text) + "', CGender='"+gender+"', CPhoto='"+textBoxPhoto.Text+"' where ClienID='" + client_id + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data update successfully..");
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Try again update..  " + ex.Message);
            }
        }

        private void bttnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Branch_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranceOfBank branceOfBank = new BranceOfBank();
            branceOfBank.ShowDialog();
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

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from csa.Clien where ClienID='" + client_id + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Date Successful.. ");
            conn.Close();
        }
    }
}
