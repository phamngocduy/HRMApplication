using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using HRM.Webpages.Forms.HRM1.Utils;
namespace HRM.Webpages.Forms
{
    public partial class BHXH_3_TangBHYT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {

                TangBHYT3.Visible = false;
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

        //load report
        public void reportload()
        {
            string a = TextBox1.Text;
            int thanght, namht;
            bool thang = int.TryParse(a.Substring(0, 2), out thanght);
            bool nam = int.TryParse(a.Substring(3, 4), out namht);
            string ngaybd1 = "11";
            string ngaykt1 = "11";

            switch (thanght)
            {
                case 1: ngaybd1 = "12/16/" + (namht - 1); ngaykt1 = "01/15/" + namht; break;
                case 2: ngaybd1 = "01/16/" + namht; ngaykt1 = "02/15/" + namht; break;
                case 3: ngaybd1 = "02/16/" + namht; ngaykt1 = "03/15/" + namht; break;
                case 4: ngaybd1 = "03/16/" + namht; ngaykt1 = "04/15/" + namht; break;
                case 5: ngaybd1 = "04/16/" + namht; ngaykt1 = "05/15/" + namht; break;
                case 6: ngaybd1 = "05/16/" + namht; ngaykt1 = "06/15/" + namht; break;
                case 7: ngaybd1 = "06/16/" + (namht); ngaykt1 = "07/15/" + namht; break;
                case 8: ngaybd1 = "07/16/" + namht; ngaykt1 = "08/15/" + namht; break;
                case 9: ngaybd1 = "08/16/" + namht; ngaykt1 = "09/15/" + namht; break;
                case 10: ngaybd1 = "09/16/" + namht; ngaykt1 = "10/15/" + namht; break;
                case 11: ngaybd1 = "10/16/" + namht; ngaykt1 = "11/15/" + namht; break;
                case 12: ngaybd1 = "11/16/" + namht; ngaykt1 = "12/15/" + (namht + 1); break;
            }
            //neu khong chon ngay thi bao loi
      
            ////sub report para
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(Server.MapPath("~/Forms/HRM1/crystal/BHXH_3_TangBHYT.rpt"));
            rptDoc.LoadConnectionString(); // Fix bug
            //rptDoc.SetDatabaseLogon("sa", "123456");
            TangBHYT3.ReportSource = rptDoc;




            rptDoc.SetParameterValue("@TuThangNam", ngaybd1);
            rptDoc.SetParameterValue("@DenThangNam", ngaykt1);

            //hien report
            TangBHYT3.Visible = true;
        }
    }
}
