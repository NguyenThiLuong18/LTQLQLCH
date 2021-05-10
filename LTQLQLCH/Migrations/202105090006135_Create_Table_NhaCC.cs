namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCCs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 20),
                        TenNCC = c.String(maxLength: 50),
                        SDT = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            AddColumn("dbo.HangHoas", "NhaCC_MaNCC", c => c.String(maxLength: 20));
            CreateIndex("dbo.HangHoas", "NhaCC_MaNCC");
            AddForeignKey("dbo.HangHoas", "NhaCC_MaNCC", "dbo.NhaCCs", "MaNCC");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HangHoas", "NhaCC_MaNCC", "dbo.NhaCCs");
            DropIndex("dbo.HangHoas", new[] { "NhaCC_MaNCC" });
            DropColumn("dbo.HangHoas", "NhaCC_MaNCC");
            DropTable("dbo.NhaCCs");
        }
    }
}
