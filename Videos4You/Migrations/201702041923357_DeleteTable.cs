namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }

        public override void Down()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
