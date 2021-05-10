namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ChiTietXuat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietXuats",
                c => new
                    {
                        STT = c.Int(nullable: false, identity: true),
                        MaPX = c.String(maxLength: 20),
                        MaHH = c.String(maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        NgayXuat = c.DateTime(nullable: false, storeType: "date"),
                        MaKH = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.STT)
                .ForeignKey("dbo.HangHoas", t => t.MaHH)
                .ForeignKey("dbo.PhieuXuats", t => t.MaPX)
                .Index(t => t.MaPX)
                .Index(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietXuats", "MaPX", "dbo.PhieuXuats");
            DropForeignKey("dbo.ChiTietXuats", "MaHH", "dbo.HangHoas");
            DropIndex("dbo.ChiTietXuats", new[] { "MaHH" });
            DropIndex("dbo.ChiTietXuats", new[] { "MaPX" });
            DropTable("dbo.ChiTietXuats");
        }
    }
}
