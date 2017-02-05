namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNullableForRegDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "RegisteredDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "RegisteredDate", c => c.DateTime(nullable: false));
        }
    }
}
