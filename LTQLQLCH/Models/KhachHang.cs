using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQLQLCH.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
     
        public string MaKH { get; set; }
        

        public string TenKH { get; set; }

        [AllowHtml]
        public string DiaChi { get; set; }

        public string SDT { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<PhieuXuat> PhieuXuats { get; set; }

    }
}