namespace Videos4You.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, Released, DurationInMinutes, Description, TimesRented)" +
                "VALUES (" +
                "'Titanic'," +
                " 'Romance/Drama'," +
                " '12. March 1998'," +
                " 194," +
                " 'A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic'," +
                "0)");

            Sql("INSERT INTO Movies (Name, Genre, Released, DurationInMinutes, Description, TimesRented)" +
                "VALUES (" +
                "'Terminator'," +
                " 'Action/Sci-Fi'," +
                " '26. October 1984'," +
                " 107," +
                " 'A seemingly indestructible humanoid cyborg is sent from 2029 to 1984 to assassinate a waitress, whose unborn son will lead humanity in a war against the machines, while a soldier from that war is sent to protect her at all costs'," +
                "0)");

            Sql("INSERT INTO Movies (Name, Genre, Released, DurationInMinutes, Description, TimesRented)" +
                "VALUES (" +
                "'Shrek'," +
                " 'Animation/Adventure/Comedy'," +
                " '18. May 2001'," +
                " 90," +
                " 'After his swamp is filled with magical creatures, Shrek agrees to rescue Princess Fiona for a villainous lord in order to get his land back'," +
                "0)");

            Sql("INSERT INTO Movies (Name, Genre, Released, DurationInMinutes, Description, TimesRented)" +
                "VALUES (" +
                "'Die Hard'," +
                " 'Action/Thriller'," +
                " '20. July 1988'," +
                " 131," +
                " 'John McClane, officer of the NYPD, tries to save his wife Holly Gennaro and several others that were taken hostage by German terrorist Hans Gruber during a Christmas party at the Nakatomi Plaza in Los Angeles'," +
                "0)");

            Sql("INSERT INTO Movies (Name, Genre, Released, DurationInMinutes, Description, TimesRented)" +
                "VALUES (" +
                "'Iron Man'," +
                " 'Action/Adventure/Sci-Fi'," +
                " '1. May 2008'," +
                " 126," +
                " 'After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil'," +
                "0)");
        }
        
        public override void Down()
        {
        }
    }
}
