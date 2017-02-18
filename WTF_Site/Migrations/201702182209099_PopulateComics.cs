namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateComics : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Comics (Title, Summary, Price) VALUES ('Xybermorphs Issue #1', 'We meet our first heros, and our first villans!', 3)");
            Sql("INSERT INTO Comics (Title, Summary, Price) VALUES ('Xybermorphs Issue #2', 'We meet our second heros, and our second villans!', 4)");
            Sql("INSERT INTO Comics (Title, Summary, Price) VALUES ('Xybermorphs Issue #3', 'We meet our third heros, and our third villans!', 5)");
            Sql("INSERT INTO Comics (Title, Summary, Price) VALUES ('Xybermorphs Issue #4', 'We meet our fourth heros, and our fourth villans!', 6)");
        }


        public override void Down()
        {
        }
    }
}
