using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace BandFinder.Models
{
    public class ConcertForm

    {
        [Key]
        public int ConcertID { get; set; }

        [Required(ErrorMessage = "Don't make us guess.  What Venue are we talking about?")]
        public string Venue { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostCode { get; set; }

        [Required]
        public string Area { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int RemainingTickets { get; set; }

    }

}