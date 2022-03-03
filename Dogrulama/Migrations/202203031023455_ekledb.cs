namespace Dogrulama.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekledb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kisis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        İsim = c.String(),
                        Soyisim = c.String(),
                        Dogumyılı = c.DateTime(nullable: false),
                        tchash = c.Binary(nullable: false),
                        tcsalt = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kisis");
        }
    }
}
