using System;

namespace TheRightPriceGame
{
    public class Movie
    {
        public DateTime releaseDate { get; set; }
        public string name { get; set; }
        public string genre { get; set; }

        public override string ToString()
        {
            return $"Name: {name} \nReleaseDate: {releaseDate} \nGenre: {genre}";
        }
    }
}