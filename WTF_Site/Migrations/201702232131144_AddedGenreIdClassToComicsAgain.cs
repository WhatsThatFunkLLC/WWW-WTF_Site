namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreIdClassToComicsAgain : DbMigration
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
            
            AddColumn("dbo.Comics", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Comics", "GenreId");
            AddForeignKey("dbo.Comics", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comics", "GenreId", "dbo.Genres");
            DropIndex("dbo.Comics", new[] { "GenreId" });
            DropColumn("dbo.Comics", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
