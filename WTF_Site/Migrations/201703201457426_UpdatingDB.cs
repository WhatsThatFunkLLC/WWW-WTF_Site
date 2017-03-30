namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDB : DbMigration
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
            AddColumn("dbo.Comics", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            CreateIndex("dbo.Comics", "GenreId");
            AddForeignKey("dbo.Comics", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comics", "GenreId", "dbo.Genres");
            DropIndex("dbo.Comics", new[] { "GenreId" });
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Comics", "ReleaseDate");
            DropColumn("dbo.Comics", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
