using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace BandFinder.Models
{
    public class BandImageForm
    {
        [Key]
        public int BandID { get; set; }

        public string BandTitle { get; set; }

        public IFormFile BandImage { get; set; }
    }
}
