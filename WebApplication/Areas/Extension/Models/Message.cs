using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.Extension.Databases.Models
{
    public partial class Message
    {
		[Required]
        public int id { get; set; }
		[Required]
        public System.DateTime Date { get; set; }
		[Required]
        public string Content { get; set; }
        public string Users { get; set; }
        public string Read { get; set; }
        public string Star { get; set; }

    }
}
