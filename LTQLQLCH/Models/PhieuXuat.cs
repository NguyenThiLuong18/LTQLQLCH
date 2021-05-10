using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("PhieuXuats")]
    public class PhieuXuat
    {
        [Key]
        [StringLength(20)]
        public string MaPX { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTao { get; set; }

        [StringLength(50)]
        public string MaKH { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }
    }
}