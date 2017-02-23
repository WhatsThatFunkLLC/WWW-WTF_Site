namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleaseDateToComics : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comics", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comics", "ReleaseDate");
        }
    }
}
