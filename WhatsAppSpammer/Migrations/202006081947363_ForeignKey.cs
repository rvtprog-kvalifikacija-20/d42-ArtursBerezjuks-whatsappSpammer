namespace WhatsAppSpammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhoneNumbers", "Name", "dbo.NumberBases");
            DropIndex("dbo.PhoneNumbers", new[] { "Name" });
            DropPrimaryKey("dbo.NumberBases");
            DropPrimaryKey("dbo.PhoneNumbers");
            AddColumn("dbo.NumberBases", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PhoneNumbers", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.PhoneNumbers", "NumberBase_Id", c => c.Int());
            AlterColumn("dbo.NumberBases", "Name", c => c.String());
            AlterColumn("dbo.PhoneNumbers", "Number", c => c.String());
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.String());
            AddPrimaryKey("dbo.NumberBases", "Id");
            AddPrimaryKey("dbo.PhoneNumbers", "Id");
            CreateIndex("dbo.PhoneNumbers", "NumberBase_Id");
            AddForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases");
            DropIndex("dbo.PhoneNumbers", new[] { "NumberBase_Id" });
            DropPrimaryKey("dbo.PhoneNumbers");
            DropPrimaryKey("dbo.NumberBases");
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.String(maxLength: 128));
            AlterColumn("dbo.PhoneNumbers", "Number", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NumberBases", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.PhoneNumbers", "NumberBase_Id");
            DropColumn("dbo.PhoneNumbers", "Id");
            DropColumn("dbo.NumberBases", "Id");
            AddPrimaryKey("dbo.PhoneNumbers", "Number");
            AddPrimaryKey("dbo.NumberBases", "Name");
            CreateIndex("dbo.PhoneNumbers", "Name");
            AddForeignKey("dbo.PhoneNumbers", "Name", "dbo.NumberBases", "Name");
        }
    }
}
