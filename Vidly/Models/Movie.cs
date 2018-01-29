using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Globalization;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        
        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
    }
}