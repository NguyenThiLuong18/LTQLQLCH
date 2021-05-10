using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("PhieuNhaps")]
    public class PhieuNhap
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaPN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        public string NhaCC_MaNCC { get; set; }

        [ForeignKey("NhaCC_MaNCC")]
        public NhaCC NhaCC { get; set; }
        public ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
    }
}