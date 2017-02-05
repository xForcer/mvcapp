namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(nullable: false, maxLength: 32),
                })
                .PrimaryKey(t => t.Id);


        }

        public override void Down()
        {

            DropTable("dbo.Genres");

        }
    }
}
