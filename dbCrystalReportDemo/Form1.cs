using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbCrystalReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crvViewer_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=MIS14;Initial Catalog=report;Integrated Security=True;");
            sqlcon.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from Product",sqlcon);
            DataSet dsProduct = new DataSet();
            sqlDA.Fill(dsProduct,"Product");
            sqlcon.Close();

            SqlDataAdapter sqlDA2 = new SqlDataAdapter("Select * from Customer", sqlcon);
            sqlDA2.Fill(dsProduct,"Customer");

            CrystalReport.crptProductReport crptProduct = new CrystalReport.crptProductReport();       
            crptProduct.Database.Tables["Product"].SetDataSource(dsProduct.Tables[0]);
            crptProduct.Database.Tables["Customer"].SetDataSource(dsProduct.Tables[1]);

            crvViewer.ReportSource = null;
            crvViewer.ReportSource = crptProduct;

        }
    }
}
