namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreClassToComics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Comics", "Genre_Id", c => c.Byte());
            CreateIndex("dbo.Comics", "Genre_Id");
            AddForeignKey("dbo.Comics", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comics", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Comics", new[] { "Genre_Id" });
            DropColumn("dbo.Comics", "Genre_Id");
            DropTable("dbo.Genres");
        }
    }
}
