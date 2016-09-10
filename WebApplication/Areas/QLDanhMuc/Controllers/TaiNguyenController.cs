using System;
using System.IO;
using System.Web;
using System.Linq;
using System.Data;
using System.Web.Mvc;
using System.Data.Entity;
using System.Transactions;

using HRM.Databases.Models;
using HRM.QLDanhMuc.Models;
namespace HRM.QLDanhMuc.Controllers
{
    public class TaiNguyenController : Controller
    {
        private HRMDBEntities db = new HRMDBEntities();

        public ActionResult Index(int? parent)
        {
            ViewBag.Parent = db.TaiNguyen.Find(parent);
            var models = db.TaiNguyen.Where(tn => parent.HasValue ? tn.idTaiNguyen == parent.Value : tn.idTaiNguyen == null);
            return View(models.ToList());
        }

        //
        // GET: /TaiNguyen/Details/5

        public ActionResult Details(int id = 0)
        {
            TaiNguyen dmtainguyen = db.TaiNguyen.Find(id);
            if (dmtainguyen == null)
            {
                return HttpNotFound();
            }
            return View(dmtainguyen);
        }

        public ActionResult Create(int? parent, bool isFolder = false)
        {
            var model = new TaiNguyen
            {
                idTaiNguyen = parent,
                laThuMuc = isFolder
            };
            model.Include(db);
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(TaiNguyen model)
        {
            if (ModelState.IsValid)
                using (var scope = new TransactionScope())
                {
                    db.TaiNguyen.Add(model);
                    db.SaveChanges();
                    model.Include(db);
                    if (model.laThuMuc)
                        try
                        {
                            Create(model.getFolder());
                            scope.Complete();
                            return RedirectToAction("Index", new { parent = model.idTaiNguyen });
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError("tenTaiNguyen", e.Message);
                        }
                    else
                        try
                        {
                            if (!String.IsNullOrEmpty(model.tepDinhKem))
                            {
                                var file = Request.Files[0];
                                model.tepDinhKem = file.FileName;
                                db.SaveChanges();
                                Upload(file, model.getFolder());
                            }
                            scope.Complete();
                            return RedirectToAction("Index", new { parent = model.idTaiNguyen });
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError("tepDinhKem", e.Message);
                        }
                }
            return View(model);
        }

        public ActionResult Rename(int id)
        {
            return View(db.TaiNguyen.Find(id));
        }
        [HttpPost]
        public ActionResult Rename(TaiNguyen model, string folder)
        {
            if (ModelState.IsValid)
                using (var scope = new TransactionScope())
                    try
                    {
                        db.Entry(model).State = EntityState.Modified;
                        db.SaveChanges();
                        model.Include(db);
                        if (model.laThuMuc)
                            Rename(folder, model.getFolder());
                        scope.Complete();
                        return RedirectToAction("Index", new { parent = model.idTaiNguyen });
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("tenTaiNguyen", e.Message);
                    }
            return View(model);
        }

        public ActionResult Move(int? id, int? parent)
        {
            if (id.HasValue)
                parent = ((Session["Selected"] = db.TaiNguyen.Find(id)) as TaiNguyen).idTaiNguyen;
            else Session["Selected"] = null;
            return RedirectToAction("Index", new { parent = parent });
        }
        [HttpPost]
        public ActionResult Paste(int id, int? parent)
        {
            using (var scope = new TransactionScope())
                try
                {
                    var selected = (TaiNguyen)Session["Selected"];
                    selected = db.TaiNguyen.Find(selected.id);
                    var tainguyen = db.TaiNguyen.Find(parent);
                    var root = Server.MapPath(App_Root);
                    var src = Path.Combine(root, selected.getFolder());
                    var dst = Path.Combine(root, tainguyen == null ? "." : tainguyen.getFolder());

                    selected.idTaiNguyen = tainguyen == null ? null : (int?)tainguyen.id;
                    db.Entry(selected).State = EntityState.Modified;
                    db.SaveChanges();
                    if (selected.laThuMuc)
                        Directory.Move(src, Path.Combine(dst, selected.tenTaiNguyen));
                    else
                        if (!String.IsNullOrEmpty(selected.tepDinhKem))
                            System.IO.File.Move(src + "/" + selected.tepDinhKem, Path.Combine(dst, selected.tepDinhKem));
                    scope.Complete();
                    Session["Selected"] = null;
                }
                catch (Exception e)
                {
                    TempData["Message"] = e.Message;
                }
            return RedirectToAction("Index", new { parent = parent });
        }

        public ActionResult Upload(int id)
        {
            return View(db.TaiNguyen.Find(id));
        }
        [HttpPost]
        public ActionResult Upload(TaiNguyen model)
        {
            var tainguyen = db.TaiNguyen.Find(model.id);
            using (var scope = new TransactionScope())
                try
                {
                    if (!String.IsNullOrEmpty(tainguyen.tepDinhKem))
                        Delete(tainguyen.tepDinhKem, tainguyen.getFolder());
                    tainguyen.tepDinhKem = null;
                    db.Entry(tainguyen).State = EntityState.Modified;
                    db.SaveChanges();
                    scope.Complete();
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("tepDinhKem", e.Message);
                    return View(model);
                }
            using (var scope = new TransactionScope())
                try
                {
                    var file = Request.Files[0];
                    tainguyen.tepDinhKem = file.FileName;
                    db.Entry(tainguyen).State = EntityState.Modified;
                    db.SaveChanges();
                    if (!String.IsNullOrEmpty(model.tepDinhKem))
                        Upload(file, tainguyen.getFolder());
                    scope.Complete();
                    return RedirectToAction("Index", new { parent = tainguyen.idTaiNguyen });
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("tepDinhKem", e.Message);
                }
            return View(model);
        }

        public ActionResult Download(int id)
        {
            var tainguyen = db.TaiNguyen.Find(id);
            var root = Server.MapPath(App_Root);
            var path = tainguyen.getFolder();
            var file = tainguyen.tepDinhKem;
            return File(new StreamReader(Path.Combine(root, path, file)).BaseStream, "data", file);
        }

        public ActionResult Delete(int id)
        {
            return View(db.TaiNguyen.Find(id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var tainguyen = db.TaiNguyen.Find(id);
            if (tainguyen.laThuMuc)
                using (var scope = new TransactionScope())
                {
                    foreach (var tn in tainguyen.getChildren().ToArray())
                        DeleteConfirmed(tn.id);
                    var path = tainguyen.getFolder();
                    db.TaiNguyen.Remove(tainguyen);
                    db.SaveChanges();
                    Delete(path);
                    scope.Complete();
                }
            else
                using (var scope = new TransactionScope())
                {
                    var path = tainguyen.getFolder();
                    db.TaiNguyen.Remove(tainguyen);
                    db.SaveChanges();
                    if (!String.IsNullOrEmpty(tainguyen.tepDinhKem))
                        Delete(tainguyen.tepDinhKem, path);
                    scope.Complete();
                }
            return RedirectToAction("Index", new { parent = tainguyen.idTaiNguyen });
        }

        private const string App_Root = @"~/App_Data/UPLOADS";
        private void Create(string path)
        {
            var root = Server.MapPath(App_Root);
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
            path = Path.Combine(root, path);
            if (Directory.Exists(path))
                throw new Exception(String.Format("A subdirectory or file {0} already exists.", new DirectoryInfo(path).Name));
            else Directory.CreateDirectory(path);
        }
        private void Upload(HttpPostedFileBase file, string path)
        {
            var root = Server.MapPath(App_Root);
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
            path = Path.Combine(root, path, file.FileName);
            if (System.IO.File.Exists(path))
                throw new Exception(String.Format("A subdirectory or file {0} already exists.", file.FileName));
            else file.SaveAs(path);
        }
        private void Rename(string src, string dst)
        {
            var root = Server.MapPath(App_Root);
            Directory.Move(Path.Combine(root, src), Path.Combine(root, dst));
        }
        private void Delete(string file, string path)
        {
            var root = Server.MapPath(App_Root);
            System.IO.File.Delete(Path.Combine(root, path, file));
        }
        private void Delete(string folder)
        {
            var root = Server.MapPath(App_Root);
            Directory.Delete(Path.Combine(root, folder));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}