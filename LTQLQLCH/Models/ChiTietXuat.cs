using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("ChiTietXuats")]
    public class ChiTietXuat
    {
        [Key]
        public int STT { get; set; }

        [StringLength(20)]
        public string MaPX { get; set; }

        [StringLength(20)]
        public string MaHH { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXuat { get; set; }

        [StringLength(20)]
        public string MaKH { get; set; }

        public HangHoa HangHoa { get; set; }

        public PhieuXuat PhieuXuat { get; set; }
    }
}