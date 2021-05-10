using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQLQLCH.Models
{
    public partial class LTQLQLCHDbContext : DbContext
    {
        public LTQLQLCHDbContext()
            : base("name=LTQLQLCHDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<ChiTietXuat> ChiTietXuats { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
