namespace Proga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BildngTypeId = c.Int(nullable: false),
                        Square = c.Double(nullable: false),
                        Rooms = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Floor = c.Int(nullable: false),
                        bildingType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BildingTypes", t => t.bildingType_Id)
                .Index(t => t.bildingType_Id);
            
            CreateTable(
                "dbo.BildingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BildingName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bildings", "bildingType_Id", "dbo.BildingTypes");
            DropIndex("dbo.Bildings", new[] { "bildingType_Id" });
            DropTable("dbo.BildingTypes");
            DropTable("dbo.Bildings");
        }
    }
}
