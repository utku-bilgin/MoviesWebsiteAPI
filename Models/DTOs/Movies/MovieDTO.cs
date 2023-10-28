﻿using Models.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Movies
{
    public class MovieDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MoviePosterUrl { get; set; }
        public string MovieTrailerUrl { get; set; }
        public string? MovieUrl { get; set; }
        public string Description { get; set; }
        public string ProductionYear { get; set; }
        public string MovieDuration { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public double? ImdbRating { get; set; }

        //public CategoryDTO Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        //public string CategoryName { get; set; }
    }
}
