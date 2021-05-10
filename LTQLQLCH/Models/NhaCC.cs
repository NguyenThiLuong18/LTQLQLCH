using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("NhaCCs")]
    public class NhaCC
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaNCC { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }
        [StringLength(20)]
        public string SDT { get; set; }
        public ICollection<HangHoa> HangHoas { get; set; }
        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}