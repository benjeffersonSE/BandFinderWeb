using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BandFinder.Models
{
    public class Band

    {
        [Required]
        [Key]
        public int BandID { get; set; }

        [Required]
        public string BandTitle { get; set; }

        [Required]
        public string BandGenre { get; set; }

        public string BandDescription { get; set; }

        public string BandImage { get; set; }

        public decimal BandPrice { get; set; }

        public int Stars { get; set; }

        [DataType(DataType.Date)]
        public DateTime BandDate { get; set; }

        public string BandArea { get; set; }

        public string BandImageMobile { get; set; }

    }

}