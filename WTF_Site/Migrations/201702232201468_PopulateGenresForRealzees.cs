namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresForRealzees : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Metal')");
        }
        
        public override void Down()
        {
        }
    }
}
