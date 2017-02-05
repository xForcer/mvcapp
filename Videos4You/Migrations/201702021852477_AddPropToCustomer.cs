namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "RegisteredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "RegisteredDate");
        }
    }
}
