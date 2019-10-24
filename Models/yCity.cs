using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class yCity
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Sehir { get; set; }

    }
}