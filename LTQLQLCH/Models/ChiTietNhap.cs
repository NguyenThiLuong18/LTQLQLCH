using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("ChiTietNhaps")]
    public class ChiTietNhap
    {
        [Key]
        public int STT { get; set; }

        [StringLength(20)]
        public string MaPN { get; set; }

        [StringLength(20)]
        public string MaHH { get; set; }
        public int SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNhap { get; set; }

        [StringLength(20)]
        public string MaNCC { get; set; }

        public HangHoa HangHoa { get; set; }

        public PhieuNhap PhieuNhap { get; set; }
    }
}