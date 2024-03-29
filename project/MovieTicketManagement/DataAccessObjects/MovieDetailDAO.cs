﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MovieDetailDAO
    {
        public static List<MovieDetail> getAll()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieDetails.ToList();
            }
        }

        public static void addNewMovieDetail(MovieDetail movieDetail)
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                context.Add(movieDetail);
                context.SaveChanges();
            }
        }

        public static int countID()
        {
            using(MovieTicketManagementContext context = new MovieTicketManagementContext())
            {
                return context.MovieDetails.Count() + 1;
            }
        }
    }
}
