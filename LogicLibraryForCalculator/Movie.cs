using System;
using System.Web;

namespace LogicLibraryForCalculator
{
    public class Movie
    {
        static string moviename;
         int ticketId;
         string seatNumber;

        public Movie ReturnMovieDetails(string name,int ticketID,string seatNumber)
        {
            Movie movie=new Movie(); 
            movie.ticketId = ticketID;
            movie.seatNumber = seatNumber;
            moviename=name;
        return movie;   
        
        }

    }
}
