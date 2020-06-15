    namespace WhatsAppSpammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases");
            DropIndex("dbo.PhoneNumbers", new[] { "NumberBase_Id" });
            RenameColumn(table: "dbo.PhoneNumbers", name: "NumberBase_Id", newName: "NumberBaseId");
            AlterColumn("dbo.PhoneNumbers", "NumberBaseId", c => c.Int(nullable: false));
            CreateIndex("dbo.PhoneNumbers", "NumberBaseId");
            AddForeignKey("dbo.PhoneNumbers", "NumberBaseId", "dbo.NumberBases", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumbers", "NumberBaseId", "dbo.NumberBases");
            DropIndex("dbo.PhoneNumbers", new[] { "NumberBaseId" });
            AlterColumn("dbo.PhoneNumbers", "NumberBaseId", c => c.Int());
            RenameColumn(table: "dbo.PhoneNumbers", name: "NumberBaseId", newName: "NumberBase_Id");
            CreateIndex("dbo.PhoneNumbers", "NumberBase_Id");
            AddForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases", "Id");
        }
    }
}
