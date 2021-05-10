namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhieuNhap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuNhaps",
                c => new
                    {
                        MaPN = c.String(nullable: false, maxLength: 20),
                        NgayTao = c.DateTime(nullable: false, storeType: "date"),
                        NhaCC_MaNCC = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaPN)
                .ForeignKey("dbo.NhaCCs", t => t.NhaCC_MaNCC)
                .Index(t => t.NhaCC_MaNCC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhieuNhaps", "NhaCC_MaNCC", "dbo.NhaCCs");
            DropIndex("dbo.PhieuNhaps", new[] { "NhaCC_MaNCC" });
            DropTable("dbo.PhieuNhaps");
        }
    }
}
