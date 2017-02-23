namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Comics");
            AlterColumn("dbo.Comics", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Comics", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Comics");
            AlterColumn("dbo.Comics", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Comics", "Id");
        }
    }
}
