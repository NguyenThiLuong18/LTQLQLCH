namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 20),
                        ThanhTien = c.Int(nullable: false),
                        KhachHang_MaKH = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHang_MaKH)
                .Index(t => t.KhachHang_MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_MaKH", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_MaKH" });
            DropTable("dbo.HoaDons");
        }
    }
}
