using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaHD { get; set; }

        public int ThanhTien { get; set; }
        public string KhachHang_MaKH { get; set; }

        [ForeignKey("KhachHang_MaKH")]
        public KhachHang KhachHang { get; set; }
    }
}