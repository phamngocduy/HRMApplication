using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRM.QLVayMuon.Models;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;

namespace HRM.QLVayMuon.Controllers
{
    public class ImportHoanVayController : Controller
    {
        private HRMDB1Entities db = new HRMDB1Entities();

        HoanVay hv = new HoanVay();

        // Review
        public ActionResult Review()
        {

                    string extension = System.IO.Path.GetExtension(Request.Files["FileUpload1"].FileName);
                    string path1 = string.Format("{0}/{1}", Server.MapPath("~/App_Data/HRM1/IMPORT_HOANVAY"), Request.Files["FileUpload1"].FileName);
                    ViewBag.link = path1;
                    if (System.IO.File.Exists(path1))
                        System.IO.File.Delete(path1);
                   
                    Request.Files["FileUpload1"].SaveAs(path1);
                    DataTable dt = new DataTable();

                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path1 + ";Extended Properties=Excel 12.0;Persist Security Info=False");
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("Select * from [HoanVay$]", con);
                        
                        da.Fill(dt);
                        return View(dt);
                    }
                    catch (Exception e) { 
                        TempData["Message_import"] = "Tập tin không hợp lệ";
                        return RedirectToAction("Index");
                    }

           
        }


       


        // Import
        public ActionResult Import()
        {
            return View();
        }


        public ActionResult Importexcel(string link)
        {
          int count = 0;
          try
          {
           
                  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + link + ";Extended Properties=Excel 12.0;Persist Security Info=False");
                  OleDbDataAdapter da = new OleDbDataAdapter("Select * from [HoanVay$]", con);
                  DataTable dt = new DataTable();
                  da.Fill(dt);
                  string sqlConnectionString = @"integrated security=false ;data source=tfs.vanlanguni.edu.vn;Database=hrmTTNS1; user id=hrmadmin;password=12345678;persist security info=False;";

                  //string sqlConnectionString = @"Data Source=.\SQLEXPRESS;Database=hrmTTNS;Trusted_Connection=true;Persist Security Info=True";
                  SqlConnection con1 = new SqlConnection(sqlConnectionString);
                  con1.Open();
                  
                  foreach (DataRow r in dt.Rows)
                  {
                          /* Inset Logic */
                      SqlCommand comm = new SqlCommand("insert into hoanvay(manv,ngaychungtu,sochungtu,diengiai,sotienhoan,sotienlai, idkhoanvay) values(@manv,@ngaychungtu,@sochungtu,@diengiai,@sotienhoan, @sotienlai,192)", con1);
                          comm.Parameters.AddWithValue("@manv", r[1]);
                          comm.Parameters.AddWithValue("@ngaychungtu", Convert.ToDateTime(r[3]));
                          comm.Parameters.AddWithValue("@sochungtu", r[5]);
                          comm.Parameters.AddWithValue("@diengiai", r[6]);
                          comm.Parameters.AddWithValue("@sotienhoan", Convert.ToInt32(r[10]));
                          comm.Parameters.AddWithValue("@sotienlai", Convert.ToInt32(r[11]));
                          comm.ExecuteNonQuery();
                          count++;
                  }
                  con1.Close();
                  TempData["Message"] = "Đã import thành công tất cả các hàng( " + count + " hàng)";
          }
          catch (Exception e)
          {

              TempData["Message"] = "Chỉ import được " + count + " hàng";
          }
          return RedirectToAction("Index");
        }

        //
        // GET: /ImportHoanVay/

        public ActionResult Index()
        {
            var hoanvay = from h in db.HoanVay.OrderByDescending(o => o.id)
                          //where h.KhoanVay.DatraXong == false
                          select h;
            //var hoanvays = db.HoanVay.Include(h => h.KhoanVay);
            var hoanvays = db.HoanVay;
            return View(hoanvay.ToList());
        }


        //
        // GET: /Danh sách khoản vay hiện hành"
        public ActionResult DSKhoanVayHienHanh()
        {
            var khoanvay = from k in db.KhoanVay
                           where k.DatraXong == false
                           select k;
           
            return View(khoanvay.ToList());
        }


        //
        // GET: /HoanVay/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ViewBag.HV_id = id;
            HoanVay hoanvay = db.HoanVay.Find(id);
            if (hoanvay == null)
            {
                return HttpNotFound();
            }
            return View(hoanvay);
        }

        //
        // POST: /HoanVay/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                HoanVay hoanvay = db.HoanVay.Find(id);
                //int nvid = hoanvay.KhoanVay.idNhanVienVayMuon;
                db.HoanVay.Remove(hoanvay);
                db.SaveChanges();
                TempData["Message"] = "Xóa khoản vay thành công";
            }
            catch (Exception e)
            {
                TempData["Message"] = "Xóa khoản vay không thành công";
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }




    }
}