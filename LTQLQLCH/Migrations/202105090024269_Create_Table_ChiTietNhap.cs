namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ChiTietNhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietNhaps",
                c => new
                    {
                        STT = c.Int(nullable: false, identity: true),
                        MaPN = c.String(maxLength: 20),
                        MaHH = c.String(maxLength: 20),
                        SoLuong = c.Int(nullable: false),
                        NgayNhap = c.DateTime(nullable: false, storeType: "date"),
                        MaNCC = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.STT)
                .ForeignKey("dbo.HangHoas", t => t.MaHH)
                .ForeignKey("dbo.PhieuNhaps", t => t.MaPN)
                .Index(t => t.MaPN)
                .Index(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietNhaps", "MaPN", "dbo.PhieuNhaps");
            DropForeignKey("dbo.ChiTietNhaps", "MaHH", "dbo.HangHoas");
            DropIndex("dbo.ChiTietNhaps", new[] { "MaHH" });
            DropIndex("dbo.ChiTietNhaps", new[] { "MaPN" });
            DropTable("dbo.ChiTietNhaps");
        }
    }
}
