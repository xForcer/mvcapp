namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Animated')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Western')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'History')");
        }
        
        public override void Down()
        {
        }
    }
}
