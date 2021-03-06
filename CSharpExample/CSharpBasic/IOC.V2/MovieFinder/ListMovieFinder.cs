﻿using System.Collections.Generic;

namespace IOC.V2.MovieFinder
{
    public class ListMovieFinder : IMovieFinder
    {
        public List<Movie> FindAll()
        {
            return new List<Movie>
                       {
                           new Movie
                               {
                                   Name = "Die Hard.wmv"
                               },
                           new Movie
                               {
                                   Name = "My Name is John.MPG"
                               }
                       };
        }
    }
}