namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testtt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Testing", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "TimesRented", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Description", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "DurationInMinutes", c => c.Short(nullable: false));
            AddColumn("dbo.Movies", "Released", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            
        }
    }
}
