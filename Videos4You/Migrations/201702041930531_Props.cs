namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Props : DbMigration
    {
        public override void Up()
        {
            
            AddColumn("dbo.Movies", "Released", c => c.DateTime());
            AddColumn("dbo.Movies", "DurationInMinutes", c => c.Short(nullable: false));
            AddColumn("dbo.Movies", "Description", c => c.String(nullable: false));
            AddColumn("dbo.Movies", "TimesRented", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "InStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "InStock");
            DropColumn("dbo.Movies", "TimesRented");
            DropColumn("dbo.Movies", "Description");
            DropColumn("dbo.Movies", "DurationInMinutes");
            DropColumn("dbo.Movies", "Released");
           
        }
    }
}
