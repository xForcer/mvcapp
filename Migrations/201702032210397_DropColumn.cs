namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumn : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.MovieGenres");
        }

        public override void Down()
        {
            DropTable("dbo.MovieGenres");
        }
    }
}
