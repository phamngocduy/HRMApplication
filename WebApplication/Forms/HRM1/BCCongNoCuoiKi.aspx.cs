using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using HRM.Webpages.Forms.HRM1.Utils;
namespace HRM.Webpages.Baocao
{
    public partial class BCCongNoCUoiKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                CrystalReportViewer1.Visible = false;
            }
            //khi bam export se load lai report
            else
            {
                reportload();

            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            reportload();
        }


        public void reportload() {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(Server.MapPath("~/Forms/HRM1/Crystal/CongNoCuoiKi.rpt"));
            rptDoc.LoadConnectionString(); // Fix bug
            //rptDoc.SetDatabaseLogon("sa", "123456");
            CrystalReportViewer1.ReportSource = rptDoc;
            CrystalReportViewer1.HasExportButton = true;
            CrystalReportViewer1.HasPrintButton = true;

            //neu khong chon ngay thi bao loi
            if (TextBox1.Text == "")
            {
                string url = "BCCongNoCuoiKi.aspx";
                ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Vui lòng chọn ngày báo cáo!');window.location.href = '" + url + "';", true);

            }
            else
            {
                DateTime txtday1 = //DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", null);
                    DateTime.Parse(TextBox1.Text); // Fix bug


                string ngaybd = TextBox1.Text;

                //neu chon ngay khong hop le

                rptDoc.SetParameterValue("@day1", txtday1.ToString("MM/dd/yyyy"));
                rptDoc.SetParameterValue("day2", ngaybd);
         


               
                CrystalReportViewer1.Visible = true;
            }
        }
    }
}