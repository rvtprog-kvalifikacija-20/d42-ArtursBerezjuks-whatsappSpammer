namespace WhatsAppSpammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActivationNumbers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ActivationNumbers", "MessagesSent", c => c.Int());
            AlterColumn("dbo.ActivationNumbers", "BannedDateTime", c => c.DateTime());
            AlterColumn("dbo.ActivationNumbers", "Price", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ActivationNumbers", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.ActivationNumbers", "BannedDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ActivationNumbers", "MessagesSent", c => c.Int(nullable: false));
        }
    }
}
