namespace WhatsAppSpammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class numberbasechange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NumberBases", "MessageId", "dbo.Messages");
            DropForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases");
            DropIndex("dbo.NumberBases", new[] { "MessageId" });
            DropIndex("dbo.PhoneNumbers", new[] { "NumberBase_Id" });
            DropColumn("dbo.PhoneNumbers", "Name");
            RenameColumn(table: "dbo.NumberBases", name: "MessageId", newName: "Message_Id");
            RenameColumn(table: "dbo.PhoneNumbers", name: "NumberBase_Id", newName: "Name");
            DropPrimaryKey("dbo.NumberBases");
            AlterColumn("dbo.NumberBases", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NumberBases", "Message_Id", c => c.Int());
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.String(maxLength: 128));
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.NumberBases", "Name");
            CreateIndex("dbo.NumberBases", "Message_Id");
            CreateIndex("dbo.PhoneNumbers", "Name");
            AddForeignKey("dbo.NumberBases", "Message_Id", "dbo.Messages", "Id");
            AddForeignKey("dbo.PhoneNumbers", "Name", "dbo.NumberBases", "Name");
            DropColumn("dbo.NumberBases", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NumberBases", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.PhoneNumbers", "Name", "dbo.NumberBases");
            DropForeignKey("dbo.NumberBases", "Message_Id", "dbo.Messages");
            DropIndex("dbo.PhoneNumbers", new[] { "Name" });
            DropIndex("dbo.NumberBases", new[] { "Message_Id" });
            DropPrimaryKey("dbo.NumberBases");
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.Int());
            AlterColumn("dbo.PhoneNumbers", "Name", c => c.String());
            AlterColumn("dbo.NumberBases", "Message_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.NumberBases", "Name", c => c.String());
            AddPrimaryKey("dbo.NumberBases", "Id");
            RenameColumn(table: "dbo.PhoneNumbers", name: "Name", newName: "NumberBase_Id");
            RenameColumn(table: "dbo.NumberBases", name: "Message_Id", newName: "MessageId");
            AddColumn("dbo.PhoneNumbers", "Name", c => c.String());
            CreateIndex("dbo.PhoneNumbers", "NumberBase_Id");
            CreateIndex("dbo.NumberBases", "MessageId");
            AddForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases", "Id");
            AddForeignKey("dbo.NumberBases", "MessageId", "dbo.Messages", "Id", cascadeDelete: true);
        }
    }
}
