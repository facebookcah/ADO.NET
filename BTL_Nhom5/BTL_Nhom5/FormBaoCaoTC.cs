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
using Microsoft.Reporting.WinForms;

namespace BTL_Nhom5
{
    public partial class FormBaoCaoTC : Form
    {
        public FormBaoCaoTC()
        {
            InitializeComponent();
        }

        private void FormBaoCaoTC_Load(object sender, EventArgs e)
        {

            this.rpvTaiChinh.RefreshReport();
        }

        private void btnTaoBCTC_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.QuanLyBanHangConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCTaiChinh";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@tungay", dateTimePicker1.Value.Date));
            cmd.Parameters.Add(new SqlParameter("@denngay", dateTimePicker2.Value.Date));
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            rpvTaiChinh.ProcessingMode = ProcessingMode.Local;
            rpvTaiChinh.LocalReport.ReportPath = "RptTC.rdlc";
           
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsTC";
                rds.Value = ds.Tables[0];
                rpvTaiChinh.LocalReport.DataSources.Clear();
                rpvTaiChinh.LocalReport.DataSources.Add(rds);
                rpvTaiChinh.RefreshReport();
            }
        }
    }
}
