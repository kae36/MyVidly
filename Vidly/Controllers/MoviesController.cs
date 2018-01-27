﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly static List<Movie> Movies = new List<Movie>()
        {
            new Movie() {Name = "Shrek!"},
            new Movie() {Name = "Toy Story"}
        };
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel() {Movie = movie, Customers = customers};

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content($@"id={id}");
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //Content($@"pageIndex={pageIndex},sortBy={sortBy}");
            if (!pageIndex.HasValue) pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";

            var movieViewModel = new MovieViewModel() {Movies = MoviesController.Movies};
            return View(movieViewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($@"{year}/{month}");
        }
    }
}