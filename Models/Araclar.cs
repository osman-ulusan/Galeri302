using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Galeri302.Models
{
    public class Araclar:BaseEntity
    {
        [StringLength(50)]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        public string Marka { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Model { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Yıl")]
        public string Yil { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Km { get; set; }
        
        [DisplayName("Yakıt")]
        public int YakitTipiId { get; set; }
        [ForeignKey("YakitTipiId")]
        public virtual yYakitTipi YYakitTipi { get; set; }

        [DisplayName("Vites")]
        public int VitesId { get; set; }
        [ForeignKey("VitesId")]
        public virtual yVites YVites { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Renk { get; set; }

        [DisplayName("Durum")]
        public Status Durum { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Motor Gücü")]
        public string MotorGucu { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Motor Hacmi")]
        public string MotorHacmi { get; set; }


        [DisplayName("Şehir")]
        public int SehirId { get; set; }
        [ForeignKey("SehirId")]
        public virtual yCity YCity { get; set; }

        public string Aciklama { get; set; }

        [StringLength(350)]
        public string Foto { get; set; }
    }
}