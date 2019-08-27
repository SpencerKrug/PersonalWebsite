using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        //Does not change the format. This only provides hints to the engine as to what the format should look like. Conveys the semantics of the data.
        [DataType(DataType.Date)]
        //Displays the actual format of the data.
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        //Will prevent certain characters from being entered.
        [RegularExpression (@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        //Does not change the format. This only provides hints to the engine as to what the format should look like. Conveys the semantics of the data.
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //Will prevent certain characters from being entered.
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}