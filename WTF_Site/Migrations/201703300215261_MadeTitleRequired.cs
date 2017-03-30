namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeTitleRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comics", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comics", "Title", c => c.String());
        }
    }
}
