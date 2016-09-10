using System;
using System.Linq;

using HRM.Databases.Models;
namespace HRM.QLTTNhanSu.Models
{
    public static class DiaChiNhaExt
    {
        public static void Load(this nvDiaChiNha model, string type, HRMDBEntities db)
        {/*
            try
            {
                if (model.LoaiDiaChi_id > 0) return;
                model.LoaiDiaChi_id = db.dmLoaiDiaChiNha.Where(dc => dc.maLoaiDiaChiNha == type).First().id;
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("{0} not found in {1}", type, typeof(dmLoaiDiaChiNha)), e);
            }*/
        }
    }
}