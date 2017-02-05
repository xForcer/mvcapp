namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Released) VALUES ('Titanic', 'Date')");
            Sql("INSERT INTO Movies (Name, Released) VALUES ('Terminator', 'Date')");
            Sql("INSERT INTO Movies (Name, Released) VALUES ('Shrek', 'Date')");
            Sql("INSERT INTO Movies (Name, Released) VALUES ('Die Hard', 'Date')");
            Sql("INSERT INTO Movies (Name, Released) VALUES ('Iron Man', 'Date')");
        }
        
        public override void Down()
        {
        }
    }
}
