namespace BookStoreMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Books", "Reiting", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Reiting", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Books", "Price");
        }
    }
}
