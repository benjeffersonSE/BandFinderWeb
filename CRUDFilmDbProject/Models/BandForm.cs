using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BandFinder.Models
{
    public class BandForm

    {
        [Key]
        public int BandID { get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What Band are we talking about?")]
        public string BandTitle { get; set; }

        [Required] 
        public string BandGenre { get; set; }

        public string BandDescription { get; set; }

        public IFormFile BandImage {  get; set;}

        public decimal BandPrice { get; set; }

        public int Stars { get; set; }

        public DateTime BandDate { get; set; }

        public string BandArea { get; set; }

        public IFormFile BandImageMobile { get; set; }

        public string BandImageName { get; set; }

        public string BandImageMobileName { get; set; }

    }

}