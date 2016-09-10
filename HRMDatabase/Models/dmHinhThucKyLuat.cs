using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases.Models
{
    public partial class dmHinhThucKyLuat
    {
        public dmHinhThucKyLuat()
        {
            this.nvTTKyLuats = new List<nvTTKyLuat>();
        }

		[Required]
        public int id { get; set; }
        public Nullable<int> stt { get; set; }
		[StringLength(10)]
        public string maHinhThucKyLuat { get; set; }
		[Required]
		[StringLength(50)]
        public string tenHinhThucKyLuat { get; set; }

        public virtual ICollection<nvTTKyLuat> nvTTKyLuats { get; set; }
    }
}
