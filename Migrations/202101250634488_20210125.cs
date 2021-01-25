namespace NoteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210125 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NoteRecords", "status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NoteRecords", "status", c => c.Int(nullable: false));
        }
    }
}
