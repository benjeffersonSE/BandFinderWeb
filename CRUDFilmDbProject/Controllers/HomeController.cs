using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using BandFinder.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace BandFinder.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Band> model = _context.Bands.ToList();

            //string json = JsonSerializer.Serialize(model, Formatting.Indented);
            //string json = JsonConvert.SerializeObject(model, Formatting.Indented);
            //System.IO.File.WriteAllText("wwwroot/js/index.json", json);

            //return Json(model, new JsonSerializerOptions
            //{
            //    WriteIndented = true,
            //});

            return View();
        }

        [Produces("application/json")]
        public IActionResult IndexApi() 
        {
            List<Band> model = _context.Bands.ToList();

            return Json(model, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
        }

        public IActionResult AllBands(String SearchString, String genreType, String locationType)
        {
            var bands = from b in _context.Bands

                        select b;

            if (!string.IsNullOrEmpty(SearchString))
            {
                if (!(SearchString == "All Bands"))
                {
                    bands = bands.Where(s => s.BandTitle.Contains(SearchString));
                }
            }

            if (!string.IsNullOrEmpty(genreType))
            {
                if (genreType == "All Genres")
                {
                    if (!(SearchString == "All Bands"))
                    {
                        bands = bands.Where(s => s.BandTitle.Contains(SearchString));
                    }
                }
                else
                {
                    bands = bands.Where(x => x.BandGenre == genreType);
                }
            }

            if (!string.IsNullOrEmpty(locationType))
            {
                if (locationType == "All Locations")
                {
                    if (!(SearchString == "All Bands"))
                    {
                        bands = bands.Where(s => s.BandTitle.Contains(SearchString));
                    }
                }
                else
                {
                    bands = bands.Where(x => x.BandArea == locationType);
                }
            }

            var BandGenre = _context.Bands.Select(b => b.BandGenre).Distinct();
            var BandLocation = _context.Bands.Select(b => b.BandArea).Distinct();

            List<Band> model = bands.OrderBy(s => s.BandTitle).ToList();
            ViewData["SearchString"] = SearchString;
            ViewData["FilterBandGenre"] = genreType;
            ViewData["FilterBandLocation"] = locationType;
            ViewData["BandGenre"] = BandGenre.ToList();
            ViewData["BandLocation"] = BandLocation.ToList();
            ViewData["BandGenreSelectList"] = new SelectList(BandGenre.ToList());
            ViewData["BandLocationSelectList"] = new SelectList(BandLocation.ToList());
            return View(model);
        }

        public IActionResult AllConcerts() 
        {
            List<Concert> model = _context.Concerts.ToList();
            return View(model);
        }

        public IActionResult Events(String SearchVenue, String SearchBand, DateTime startDate, DateTime endDate, String locationType)
        {

            var concerts = from c in _context.Concerts

                        select c;

            var bands = from b in _context.Bands

                        select b;

            var bandConcerts = from l in _context.BandConcert

                        select l;

            if (!string.IsNullOrEmpty(SearchVenue))
            {
                if (!(SearchVenue == "All Venues"))
                {
                    concerts = concerts.Where(s => s.Venue.Contains(SearchVenue));
                }
            }

            if (!string.IsNullOrEmpty(SearchBand))
            {
                if (!(SearchBand == "All Bands"))
                {
                    bands = bands.Where(b => b.BandTitle.Contains(SearchBand));

                    var bandId = bands.Where(x => x.BandTitle.Contains(SearchBand)).Select(i => i.BandID);
                    List<int> bandIds = bandId.ToList();

                    bandConcerts = bandConcerts.Where(x => bandIds.Contains(x.BandID));
                    var concertId = bandConcerts.Where(x => bandIds.Contains(x.BandID)).Select(i => i.ConcertID);

                    List<int> concertIds = concertId.ToList();
                    concerts = concerts.Where(x => concertIds.Contains(x.ConcertID));
                }
            }

            if (!(startDate == DateTime.MinValue))
            {
                concerts = concerts.Where(x => x.Date >= startDate);
                if (!(endDate == DateTime.MinValue))
                {
                    concerts = concerts.Where(x => x.Date >= startDate && x.Date <= endDate);
                }
            }

            if (!string.IsNullOrEmpty(locationType))
            {
                if (locationType == "All Locations")
                {
                    
                }
                else
                {
                    concerts = concerts.Where(x => x.Area == locationType);
                }
            }

            var Date = _context.Concerts.Select(c => c.Date).Distinct();
            var Location = _context.Concerts.Select(c => c.Area).Distinct();

            List<Concert> model = concerts.OrderBy(s => s.Date).ToList();
            ViewData["SearchVenue"] = SearchVenue;
            ViewData["SearchBand"] = SearchBand;
            ViewData["StartDate"] = startDate.ToString("yyyy-MM-dd");
            ViewData["EndDate"] = endDate.ToString("yyyy-MM-dd");
            ViewData["FilterConcertLocation"] = locationType;
            ViewData["ConcertLocation"] = Location.ToList();
            ViewData["ConcertLocationSelectList"] = new SelectList(Location.ToList());
            return View(model);
        }


        // note uses id because of routing in startup.cs
        [HttpGet]
        public IActionResult BandDetails(int id)
        {
            // dynamic model for multiple tables
            dynamic model = new System.Dynamic.ExpandoObject();

            var bands = from b in _context.Bands select b;
            if (id != 0)
            {
                bands = bands.Where(x => x.BandID == id);
            }
            List<Band> bandModel = bands.ToList();

            var bandConcerts = from l in _context.BandConcert select l;

            if (id != 0) 
            {
                bandConcerts = bandConcerts.Where(x => x.BandID == id);
            }

            var concertId = bandConcerts.Where(x => x.BandID == id).Select(i => i.ConcertID);

            
            List<int> concertIds = concertId.ToList();

            var concerts = from c in _context.Concerts select c;

            if (id != 0)
            {
                concerts = concerts.Where(x => concertIds.Contains(x.ConcertID));
            }
            List<Concert> concertModel = concerts.ToList();

            model.Bands = bandModel;
            model.Concerts = concertModel;

            return View(model);
        }

        [HttpGet]
        public IActionResult ConcertDetails(int id) 
        {
            dynamic model = new System.Dynamic.ExpandoObject();

            var concerts = from c in _context.Concerts select c;
            if (id != 0)
            {
                concerts = concerts.Where(x => x.ConcertID == id);
            }
            List<Concert> concertModel = concerts.ToList();

            var bandConcerts = from l in _context.BandConcert select l;

            if (id != 0)
            {
                bandConcerts = bandConcerts.Where(x => x.ConcertID == id);
            }
            var bandId = bandConcerts.Where(x => x.ConcertID == id).Select(i => i.BandID);


            List<int> bandIds = bandId.ToList();

            List<BandConcert> linkModel = bandConcerts.ToList();

            var bands = from b in _context.Bands select b;

            bands = bands.Where(x => bandIds.Contains(x.BandID));

            List<Band> bandModel = bands.ToList();

            model.Bands = bandModel;
            model.Concerts = concertModel;

            return View(model);
        }

        [HttpGet]
        public IActionResult BookingDetails(int id) 
        {
            var bands = from b in _context.Bands select b;
            if (id != 0)
            {
                bands = bands.Where(x => x.BandID == id);
            }
            List<Band> model = bands.ToList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
