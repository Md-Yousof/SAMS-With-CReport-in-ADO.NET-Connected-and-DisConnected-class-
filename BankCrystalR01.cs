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
    public partial class BankCrystalR01 : Form
    {
        SqlConnection conn;
        public BankCrystalR01()
        {
            InitializeComponent();
            string myConString = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
            conn = new SqlConnection(myConString);
        }

        private void bttnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void bttnPrntAccDetail_Click(object sender, EventArgs e)
        {
            BankCrystalR01 bankCrystalR01 = new BankCrystalR01();
            bankCrystalR01.Show();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from vw_BalanceDetail", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            //adapter.Fill(ds, "vw_BalanceDetail");
            BankCrystalReport1 sture = new BankCrystalReport1();
            sture.SetDataSource(ds);
            bankCrystalR01.crystalReportViewer1.ReportSource = sture;
            bankCrystalR01.crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
