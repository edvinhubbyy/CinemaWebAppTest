using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Data.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> entity)
        {
            
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(m => m.Genre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(m => m.ReleaseDate)
                    .IsRequired();
                
                entity.Property(m => m.Director)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(m => m.Duration)
                    .IsRequired();
                
                entity.Property(m => m.Description)
                    .IsRequired()
                    .HasMaxLength(500);
                
                entity.Property(m => m.ImageUrl)
                    .HasMaxLength(200);
                
                entity.Property(m => m.IsDeleted)
                    .HasDefaultValue(false);

                entity
                    .HasData(SeedMovies());

                

        }

        public List<Movie> SeedMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Inception",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("2010-07-16"),
                    Director = "Christopher Nolan",
                    Duration = 148,
                    Description =
                        "A skilled thief is given a chance at redemption if he can successfully perform an inception on a target's mind.",
                    ImageUrl =
                        "https://cdn.shopify.com/s/files/1/0057/3728/3618/files/inception.mpw.123395_9e0000d1-bc7f-400a- b488-15fa9e60a10c_500x749.jpg?v=1708527589"
                },
                new Movie()
                {
                    Title = "The Godfather",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1972-03-24"),
                    Director = "Francis Ford Coppola",
                    Duration = 175,
                    Description =
                        "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/b5282f72126e4919911509e034a61f66_6ce2486d-   e0da-4b7a-9148-722cdde610b8_480x.progressive.jpg?v=1573616025"
                },
                new Movie()
                {
                    Title = "Interstellar",
                    Genre = "Adventure",
                    ReleaseDate = DateTime.Parse("2014-11-07"),
                    Director = "Christopher Nolan",
                    Duration = 169,
                    Description =
                        "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/interstellar-139399_480x.progressive.jpg?v=1708527823"
                },
                new Movie()
                {
                    Title = "The Dark Knight",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2008-07-18"),
                    Director = "Christopher Nolan",
                    Duration = 152,
                    Description = "Batman faces the Joker, a criminal mastermind bent on causing chaos in Gotham City.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/darkknight.building.24x36_20e90057- f673-4cc3-9ce7-7b0d3eeb7d83_480x.progressive.jpg?v=1707491191"
                },
                new Movie()
                {
                    Title = "Pulp Fiction",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("1994-10-14"),
                    Director = "Quentin Tarantino",
                    Duration = 154,
                    Description =
                        "The lives of two mob hitmen, a boxer, and others intertwine in a series of unexpected incidents.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/pulpfiction.2436_480x.progressive.jpg?v=1620048742"
                },
                new Movie()
                {
                    Title = "The Matrix",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("1999-03-31"),
                    Director = "The Wachowskis",
                    Duration = 136,
                    Description =
                        "A computer hacker learns the shocking truth about the reality he lives in and joins a rebellion.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/Matrix.mpw.102176_bb2f6cc5-4a16-4512-881b-  f855ead3c8ec_480x.progressive.jpg?v=1708703624"
                },
                new Movie()
                {
                    Title = "Schindler's List",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1993-12-15"),
                    Director = "Steven Spielberg",
                    Duration = 195,
                    Description =
                        "A businessman saves the lives of hundreds of Jews during the Holocaust by employing them in his factories.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/9a1f9ea4a27071481cc1263e3ea11f7b_7bdb2deb-dd50-41b5- beab-8fc1cb3c895d_480x.progressive.jpg?v=1573651233"
                },
                new Movie()
                {
                    Title = "Forrest Gump",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1994-07-06"),
                    Director = "Robert Zemeckis",
                    Duration = 142,
                    Description =
                        "The story of Forrest Gump, a man with a low IQ, whose kind heart shapes the lives of those around him.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/forrest-gump---24x36_480x.progressive.jpg?v=1645558337"
                },
                new Movie()
                {
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1994-09-23"),
                    Director = "Frank Darabont",
                    Duration = 142,
                    Description =
                        "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of decency.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/shawshank_eb84716b-efa9-44dc-a19d-c17924a3f7df_480x.progressive.jpg?    v=1709821984"
                },
                new Movie()
                {
                    Title = "Avatar",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("2009-12-18"),
                    Director = "James Cameron",
                    Duration = 162,
                    Description =
                        "A paraplegic Marine dispatched to the moon Pandora becomes torn between following orders and protecting his home.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/avatar.adv.24x36_480x.progressive.jpg?v=1707410703"
                },
                new Movie()
                {
                    Title = "Gladiator",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2000-05-05"),
                    Director = "Ridley Scott",
                    Duration = 155,
                    Description =
                        "A betrayed Roman general seeks revenge against the corrupt emperor who murdered his family and sent him into     slavery.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/Gladiator.mpw.102813_480x.progressive.jpg?v=1707500493"
                },
                new Movie()
                {
                    Title = "The Avengers",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2012-05-04"),
                    Director = "Joss Whedon",
                    Duration = 143,
                    Description =
                        "Earth's mightiest heroes must come together to stop a mischievous Loki and his alien army.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/avengers.24x36_480x.progressive.jpg?v=1707410714"
                },
                new Movie()
                {
                    Title = "The Lion King",
                    Genre = "Animation",
                    ReleaseDate = DateTime.Parse("1994-06-15"),
                    Director = "Roger Allers, Rob Minkoff",
                    Duration = 88,
                    Description =
                        "A lion prince flees his kingdom after the death of his father, only to learn the true meaning of responsibility and  bravery.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/the-lion-king_273b54a5_480x.progressive.jpg?v=1725905168"
                },
                new Movie()
                {
                    Title = "Jurassic Park",
                    Genre = "Adventure",
                    ReleaseDate = DateTime.Parse("1993-06-11"),
                    Director = "Steven Spielberg",
                    Duration = 127,
                    Description =
                        "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run  amok.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/jurassic-park-1_480x.progressive.jpg?v=1708686293"
                },
                new Movie()
                {
                    Title = "Titanic",
                    Genre = "Romance",
                    ReleaseDate = DateTime.Parse("1997-12-19"),
                    Director = "James Cameron",
                    Duration = 195,
                    Description =
                        "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the ill-fated R.M.S. Titanic.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/files/titanic.24x36_480x.progressive.jpg?v=1707410721"
                },
                new Movie()
                {
                    Title = "The Silence of the Lambs",
                    Genre = "Thriller",
                    ReleaseDate = DateTime.Parse("1991-02-14"),
                    Director = "Jonathan Demme",
                    Duration = 118,
                    Description =
                        "A young FBI cadet must confide in an incarcerated cannibal to catch another serial killer.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/The_Silence_of_the_Lambs_Movie_Poster_480x.progressive.jpg?v=1707410734"
                },
                new Movie()
                {
                    Title = "Saving Private Ryan",
                    Genre = "War",
                    ReleaseDate = DateTime.Parse("1998-07-24"),
                    Director = "Steven Spielberg",
                    Duration = 169,
                    Description =
                        "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/saving-private-ryan-24x36_480x.progressive.jpg?v=1707410738"
                },
                new Movie()
                {
                    Title = "Fight Club",
                    Genre = "Drama",
                    ReleaseDate = DateTime.Parse("1999-10-15"),
                    Director = "David Fincher",
                    Duration = 139,
                    Description = "An insomniac office worker and a soap maker form an underground fight club.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/fightclub.24x36_480x.progressive.jpg?v=1707410744"
                },
                new Movie()
                {
                    Title = "The Prestige",
                    Genre = "Mystery",
                    ReleaseDate = DateTime.Parse("2006-10-20"),
                    Director = "Christopher Nolan",
                    Duration = 130,
                    Description = "Two magicians engage in a bitter rivalry with deadly consequences.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/the-prestige-24x36_480x.progressive.jpg?v=1707410754"
                },
                new Movie()
                {
                    Title = "Guardians of the Galaxy",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2014-08-01"),
                    Director = "James Gunn",
                    Duration = 121,
                    Description =
                        "A group of intergalactic criminals must work together to stop a fanatical warrior from taking control of the     universe.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/guardiansofthegalaxy.24x36_480x.progressive.jpg?v=1707410763"
                },
                new Movie()
                {
                    Title = "Star Wars: Episode IV - A New Hope",
                    Genre = "Sci-Fi",
                    ReleaseDate = DateTime.Parse("1977-05-25"),
                    Director = "George Lucas",
                    Duration = 121,
                    Description =
                        "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, and others to save the galaxy from the Empire's   world-destroying weapon.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/starwars-episode-iv_480x.progressive.jpg?v=1707410770"
                },
                new Movie()
                {
                    Title = "The Departed",
                    Genre = "Crime",
                    ReleaseDate = DateTime.Parse("2006-10-06"),
                    Director = "Martin Scorsese",
                    Duration = 151,
                    Description =
                        "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/thedeparted.24x36_480x.progressive.jpg?v=1707410777"
                },
                new Movie()
                {
                    Title = "Django Unchained",
                    Genre = "Western",
                    ReleaseDate = DateTime.Parse("2012-12-25"),
                    Director = "Quentin Tarantino",
                    Duration = 165,
                    Description =
                        "With the help of a bounty hunter, a freed slave sets out to rescue his wife from a brutal plantation owner.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/djangounchained.24x36_480x.progressive.jpg?v=1707410784"
                },
                new Movie()
                {
                    Title = "Black Panther",
                    Genre = "Action",
                    ReleaseDate = DateTime.Parse("2018-02-16"),
                    Director = "Ryan Coogler",
                    Duration = 134,
                    Description =
                        "T'Challa returns home to Wakanda to take his throne but faces challenges from a rival claimant.",
                    ImageUrl =
                        "https://www.movieposters.com/cdn/shop/products/blackpanther.24x36_480x.progressive.jpg?v=1707410790"
                }

            };
            return movies;
        }

        
    }
}
