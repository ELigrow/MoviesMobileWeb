using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MoviesMobileWeb
{
    class Movie
    {
        public String name { get; private set; }
        public Rating rating { get; private set; }
        public Genre genre { get; private set; }

        public Movie(String name, Rating rating, Genre genre)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }        

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (!(o is Movie)) return false;
            Movie movie = (Movie)o;
            return Object.Equals(this.name, movie.name) &&
                    this.rating == movie.rating &&
                    this.rating == movie.rating;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            hash = hash * 31 + name.SafeGetHashCode();
            hash = hash * 31 + rating.ToString().SafeGetHashCode();
            hash = hash * 31 + genre.ToString().SafeGetHashCode();
            return hash;
        }

        public override String ToString()
        {
            return "Movie{" +
                    "name='" + name + '\'' +
                    ", rating=" + rating +
                    ", genre=" + genre +
                    '}';
            }

        }
}
