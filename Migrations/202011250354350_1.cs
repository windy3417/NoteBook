namespace NoteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NoteRecords",
                c => new
                    {
                        voucheNo = c.String(nullable: false, maxLength: 20),
                        itemName = c.String(nullable: false, maxLength: 50),
                        makeTime = c.DateTime(nullable: false),
                        requesteDate = c.DateTime(nullable: false),
                        needCompletedDate = c.DateTime(nullable: false),
                        planCompletedDate = c.DateTime(nullable: false),
                        Summary = c.String(),
                        recorder = c.String(nullable: false, storeType: "ntext"),
                        userID = c.String(maxLength: 5, fixedLength: true, unicode: false),
                        requesteUserID = c.String(maxLength: 5, fixedLength: true, unicode: false),
                        responsibleUserID = c.String(maxLength: 5, fixedLength: true, unicode: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.voucheNo);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        pwd = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        DateOfCancellation = c.DateTime(),
                    })
                .PrimaryKey(t => t.userID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.user");
            DropTable("dbo.NoteRecords");
        }
    }
}
