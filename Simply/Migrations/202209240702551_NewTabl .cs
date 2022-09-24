﻿namespace Simply.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTabl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReferralCustomer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Phone = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReferralCustomer");
        }
    }
}
