namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveMovieIDfromGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieGenres", "MovieId", "dbo.Movies");
            DropIndex("dbo.MovieGenres", new[] { "MovieId" });
            RenameColumn(table: "dbo.MovieGenres", name: "MovieId", newName: "Movie_Id");
            AlterColumn("dbo.MovieGenres", "Movie_Id", c => c.Int());
            CreateIndex("dbo.MovieGenres", "Movie_Id");
            AddForeignKey("dbo.MovieGenres", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieGenres", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieGenres", new[] { "Movie_Id" });
            AlterColumn("dbo.MovieGenres", "Movie_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.MovieGenres", name: "Movie_Id", newName: "MovieId");
            CreateIndex("dbo.MovieGenres", "MovieId");
            AddForeignKey("dbo.MovieGenres", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
