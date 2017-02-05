namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullableToReleasedDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Released", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Released", c => c.String(nullable: false));
        }
    }
}
