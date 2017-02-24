namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDisplayNameToBirthdateInCustomerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(storeType: "date"));
        }
    }
}
