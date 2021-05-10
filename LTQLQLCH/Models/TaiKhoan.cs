using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLQLCH.Models
{
    [Table("TaiKhoans")]
    public class TaiKhoan
    {
        [Key]
        [Required(ErrorMessage = "Không được để trống.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Không được để trống.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}