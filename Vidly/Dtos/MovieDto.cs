﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }
        
    }
}