namespace NoteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
