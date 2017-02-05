namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Released", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Released", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
