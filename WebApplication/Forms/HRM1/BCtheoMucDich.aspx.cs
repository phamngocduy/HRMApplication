using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using HRM.Webpages.Forms.HRM1.Utils;
namespace HRM.Webpages
{
    public partial class BCChitiettheoMucDich : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            reportload();
        }


        //ham load report
        public void reportload()
        {
         //neu khong chon ngay thi bao loi
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                string url = "BCtheoMucDich.aspx";
                ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Vui lòng chọn ngày báo cáo!');window.location.href = '" + url + "';", true);

            }
            else
            {
                DateTime txtday1 = //DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", null);
                    DateTime.Parse(TextBox1.Text); // Fix bug
                DateTime txtday2 = //DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", null);
                    DateTime.Parse(TextBox2.Text); // Fix bug

                string ngaybd = TextBox1.Text;
                string ngaykt = TextBox2.Text;
                //neu chon ngay khong hop le
                if (txtday1 > txtday2)
                {
                    string url = "BCtheoMucDich.aspx";
                    ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Ngày tháng không hợp lê!');window.location.href = '" + url + "';", true);
                 }
                else
                {
                   



                    ReportDocument rptDoc = new ReportDocument();
                    rptDoc.Load(Server.MapPath("~/Forms/HRM1/crystal/bctheomucdich.rpt"));
                    rptDoc.LoadConnectionString(); // Fix bug
                    //rptDoc.SetDatabaseLogon("sa", "123456");
                    CrystalReportViewer1.ReportSource = rptDoc;



                    rptDoc.SetParameterValue("@day1", txtday1.ToString("MM/dd/yyyy"));
                    rptDoc.SetParameterValue("@day2", txtday2.ToString("MM/dd/yyyy"));
                    rptDoc.SetParameterValue("ngay1", ngaybd);
                    rptDoc.SetParameterValue("ngay2", ngaykt); 



              
                    CrystalReportViewer1.Visible = true;
                }
            }
        }
    }
}