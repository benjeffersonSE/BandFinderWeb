using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BandFinder.Models
{
    public class BandConcertForm
    {
        [Required]
        [Key, Column(Order = 0)]
        public int ConcertID { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        public int BandID { get; set; }

    }

}