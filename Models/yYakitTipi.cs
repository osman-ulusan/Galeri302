using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class yYakitTipi
    {
        public int Id { get; set; }
        public string Ytipi { get; set; }


        public virtual ICollection<Araclar> Araclars { get; set; }

    }
}