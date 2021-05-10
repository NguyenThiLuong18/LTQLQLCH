namespace LTQLQLCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        MaHH = c.String(nullable: false, maxLength: 20),
                        TenHH = c.String(maxLength: 50),
                        DonGia = c.Int(nullable: false),
                        DonViTinh = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
        }
    }
}
