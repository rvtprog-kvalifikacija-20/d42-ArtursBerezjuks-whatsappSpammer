namespace WhatsAppSpammer.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivationNumbers",
                c => new
                {
                    Number = c.String(nullable: false, maxLength: 128),
                    CountryCode = c.String(),
                    ActivationCode = c.String(),
                    MessagesSent = c.Int(),
                    CreatedDateTime = c.DateTime(nullable: false),
                    BannedDateTime = c.DateTime(),
                    Price = c.Double(),
                    SmsRegistrator = c.String(),
                })
                .PrimaryKey(t => t.Number);

            CreateTable(
                "dbo.Messages",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    MessageText = c.String(),
                    PathToImage = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.NumberBases",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    MessageId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Messages", t => t.MessageId, cascadeDelete: true)
                .Index(t => t.MessageId);

            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                {
                    Number = c.String(nullable: false, maxLength: 128),
                    HaveWhatsapp = c.Boolean(),
                    Name = c.String(),
                    Surname = c.String(),
                    Gender = c.String(),
                    NumberBase_Id = c.Int(),
                })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.NumberBases", t => t.NumberBase_Id)
                .Index(t => t.NumberBase_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumbers", "NumberBase_Id", "dbo.NumberBases");
            DropForeignKey("dbo.NumberBases", "MessageId", "dbo.Messages");
            DropIndex("dbo.PhoneNumbers", new[] { "NumberBase_Id" });
            DropIndex("dbo.NumberBases", new[] { "MessageId" });
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.NumberBases");
            DropTable("dbo.Messages");
            DropTable("dbo.ActivationNumbers");
        }
    }
}
