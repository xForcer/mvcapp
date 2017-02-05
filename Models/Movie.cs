using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videos4You.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name of the movie is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of release is required!")]
        [Display(Name = "Date of Release")]
        public DateTime? Released { get; set; }

        [Required(ErrorMessage = "Runtime in minutes is required!")]
        [Display(Name = "Runtime in Minutes")]
        public short? DurationInMinutes { get; set; }

        [Required(ErrorMessage = "Please write a short description!")]
        public string Description { get; set; }

        public int TimesRented { get; set; }

        [Required(ErrorMessage = "How many units are there for sale?")]
        [Display(Name = "Number in Stock")]
        [Range(1, 100, ErrorMessage = "Use a number between 1 and 100!")]
        public int? InStock { get; set; }

        public Genre Genres { get; set; }

        [Display(Name = "Choose a Genre")]
        [Required(ErrorMessage = "Choose a genre!")]
        public byte GenresId { get; set; }


        public DateTime? DateAdded { get; set; }


    }
}