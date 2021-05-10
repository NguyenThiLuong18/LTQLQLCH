namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhieuXuat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuXuats",
                c => new
                    {
                        MaPX = c.String(nullable: false, maxLength: 20),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        MaKH = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaPX)
                .ForeignKey("dbo.KhachHangs", t => t.MaKH)
                .Index(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuXuats", "MaKH", "dbo.KhachHangs");
            DropIndex("dbo.PhieuXuats", new[] { "MaKH" });
            DropTable("dbo.PhieuXuats");
        }
    }
}
