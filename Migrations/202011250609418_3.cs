namespace NoteBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NoteRecords", "Summary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NoteRecords", "Summary", c => c.String());
        }
    }
}
