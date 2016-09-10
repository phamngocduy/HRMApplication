using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Databases_HDLaoDong.Models
{
    public partial class sysdiagram
    {
		[Required]
		[StringLength(128)]
        public string name { get; set; }
		[Required]
        public int principal_id { get; set; }
		[Required]
        public int diagram_id { get; set; }
        public Nullable<int> version { get; set; }
        public byte[] definition { get; set; }

    }
}
