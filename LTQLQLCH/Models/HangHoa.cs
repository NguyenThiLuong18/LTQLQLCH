using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaHH { get; set; }

        [StringLength(50)]
        public string TenHH { get; set; }

        public int DonGia { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public string NhaCC_MaNCC { get; set; }
        [ForeignKey("NhaCC_MaNCC")]
        public NhaCC NhaCC { get; set; }
        public ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public ICollection<ChiTietXuat> ChiTietXuats { get; set; }
    }
}