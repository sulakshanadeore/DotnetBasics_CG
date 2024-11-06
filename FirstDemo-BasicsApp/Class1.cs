using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo_BasicsApp
{
   internal  class MovieClass
    {
     internal   static string moviename;
      internal  int ticketId;
      internal  string seatNumber;

        public MovieClass ReturnMovieDetails(string name, int ticketID, string seatNumber)
        {
            MovieClass movie = new MovieClass();
            movie.ticketId = ticketID;
            movie.seatNumber = seatNumber;
            moviename = name;
            return movie;

        }

    }
}
