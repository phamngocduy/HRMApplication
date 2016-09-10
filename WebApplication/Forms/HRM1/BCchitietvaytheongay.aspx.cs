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
    public partial class BCchitietvaytheongay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                CrystalReportViewer1.Visible = false;
                CrystalReportViewer2.Visible = false;
            }
            //khi bam export se load lai report
            else
            {
                reportload();

            }
        }
        //xu li nut xem bao cao
        protected void Button1_Click(object sender, EventArgs e)
        {
            reportload();
        }


        //load report
        public void reportload()
        {
            string id = ComboBox1.SelectedValue;

            string ten = ComboBox1.SelectedItem.ToString();


            //neu khong chon ngay thi bao loi
            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                CrystalReportViewer1.Visible = false;
         

                ////sub report para


                 ReportDocument rptDoc = new ReportDocument();
                 rptDoc.Load(Server.MapPath("~/Forms/HRM1/Crystal/BcCHitiettheoten.rpt"));
                 rptDoc.LoadConnectionString(); // Fix bug
            //rptDoc.SetDatabaseLogon("sa", "123456");
            CrystalReportViewer2.ReportSource = rptDoc;
            CrystalReportViewer2.HasExportButton = true;
            CrystalReportViewer2.HasPrintButton = true;

          



            
            rptDoc.SetParameterValue("@idnv", id);
            rptDoc.SetParameterValue("hovaten", ten); 


               
                CrystalReportViewer2.Visible = true;

            }
            else
            {
                if (TextBox1.Text == "" || TextBox2.Text == "")
                {
                    string url = "BCchitietvaytheongay.aspx";
                    ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Vui lòng chọn ngày báo cáo!');window.location.href = '" + url + "';", true);

                }

                else
                {

                    CrystalReportViewer2.Visible = false;
                    DateTime txtday1 = //DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", null);
                        DateTime.Parse(TextBox1.Text); // Fix bug
                    DateTime txtday2 = //DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", null);
                        DateTime.Parse(TextBox2.Text); // Fix bug


                    if (txtday1 > txtday2)
                    {
                        string url = "BCchitietvaytheongay.aspx";
                        ClientScript.RegisterStartupScript(this.GetType(), "callfunction", "alert('Ngày tháng không hợp lê!');window.location.href = '" + url + "';", true);

                    }
                    else
                    {

                        string ngaybd = TextBox1.Text;
                        string ngaykt = TextBox2.Text;
                        //neu chon ngay khong hop le


                        ReportDocument rptDoc = new ReportDocument();
                        rptDoc.Load(Server.MapPath("~/Forms/HRM1/Crystal/BcCHitiettheotenNgay.rpt"));
                        rptDoc.LoadConnectionString(); // Fix bug
                        //rptDoc.SetDatabaseLogon("sa", "123456");
                        CrystalReportViewer1.ReportSource = rptDoc;
                        CrystalReportViewer1.HasExportButton = true;
                        CrystalReportViewer1.HasPrintButton = true;

                        //parameter

                        rptDoc.SetParameterValue("@idnv", id);
                        rptDoc.SetParameterValue("hovaten", ten);
                        rptDoc.SetParameterValue("@day1", txtday1.ToString("MM/dd/yyyy"));
                        rptDoc.SetParameterValue("@day2", txtday2.ToString("MM/dd/yyyy"));
                        rptDoc.SetParameterValue("ngay1", ngaybd);
                        rptDoc.SetParameterValue("ngay2", ngaykt); 

                        //hien bc
                        CrystalReportViewer1.Visible = true;

                    }
                }
            }
        }
    }
}