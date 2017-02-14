namespace WTF_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectedCustomerMembershipType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AccountType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AccountType", c => c.String());
        }
    }
}
