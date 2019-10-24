using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public int SaveUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUser { get; set; }
    }
}