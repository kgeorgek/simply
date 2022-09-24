namespace Simply.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReiewColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Review", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Review");
        }
    }
}
