using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BandFinder.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BandFinder.Controllers
{
    [Authorize(Roles = "Manager")]
    public class CMSController : Controller
    {
        private readonly ILogger<CMSController> _logger;

        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public CMSController(ILogger<CMSController> logger, ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _logger = logger;
            _webHostEnvironment = hostEnvironment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            dynamic model = new System.Dynamic.ExpandoObject();

            var bands = from b in _context.Bands select b;
            List<Band> bandModel = _context.Bands.ToList();

            var concerts = from c in _context.Concerts select c;
            List<Concert> concertModel = concerts.Distinct().ToList();

            var bandConcerts = from l in _context.BandConcert select l;
            //bandConcerts = (IQueryable<BandConcert>)bandConcerts.Select(x => x.ConcertID).Distinct();
            List<BandConcert> linkModel = bandConcerts.OrderBy(x => x.ConcertID).Distinct().ToList();
            List<int> concertIds = new List<int>();

            foreach (var item in linkModel) 
            {
                concertIds.Add(item.ConcertID);
            }

            IEnumerable<int> distinctIds = @concertIds.Distinct();

            //var concertId = bandConcerts.Where(x => x.ConcertID.Contains("")).Select(i => i.ConcertID);
            //List<int> concertIds = concertId.Distinct().ToList();
            //bandConcerts.Distinct().ToList();
            //bandConcerts.ToList();

            model.Bands = bandModel;
            model.Concerts = concertModel;
            model.Link = linkModel;
            model.Distinct = distinctIds;

            return View(model);
        }

        [HttpGet]
        public IActionResult AddBand()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddConcert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBand(BandForm model)
        {
            if (ModelState.IsValid)
            {
                string[] permittedExtensions = { ".gif", ".jpg", ".jpeg", ".png" };

                if (model.BandImage != null) 
                {
                    var tupleLarge = UploadedFileLarge(model);
                    string uniqueFileNameLarge = tupleLarge.Item1;
                    string fileExtLarge = tupleLarge.Item2;
                    long fileSizeLarge = tupleLarge.Item3;

                    // if file is greater than 5 MB
                    if (fileSizeLarge > 5000000)
                    {
                        ViewBag.msg = "Image Large Too Big: " + fileSizeLarge.ToString();

                        return View();
                    }
                    // if file is not a whitelisted type
                    if (!permittedExtensions.Contains(fileExtLarge))
                    {
                        ViewBag.msg = "Wrong File type " + fileExtLarge;
                        return View();
                    }
                    model.BandImageName = uniqueFileNameLarge;
                }

                if (model.BandImageMobile != null) 
                {
                    var tupleSmall = UploadedFileSmall(model);
                    string uniqueFileNameSmall = tupleSmall.Item1;
                    string fileExtSmall = tupleSmall.Item2;
                    long fileSizeSmall = tupleSmall.Item3;

                    // if file is greater than 5 MB
                    if (fileSizeSmall > 5000000)
                    {
                        ViewBag.msg = "Image Small Too Big: " + fileSizeSmall.ToString();

                        return View();
                    }
                    // if file is not a whitelisted type
                    if (!permittedExtensions.Contains(fileExtSmall))
                    {
                        ViewBag.msg = "Wrong File type " + fileExtSmall;
                        return View();
                    }
                    model.BandImageMobileName = uniqueFileNameSmall;
                }

                Band newBand = new Band
                {
                    BandTitle = model.BandTitle,
                    BandGenre = model.BandGenre,
                    BandDescription = model.BandDescription,
                    BandImage = model.BandImageName,
                    BandImageMobile = model.BandImageMobileName,
                    BandPrice = model.BandPrice,
                    Stars = model.Stars,
                    BandDate = model.BandDate,
                    BandArea = model.BandArea

                };

                _context.Add(newBand);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();

        }

        private Tuple<string, string, long> UploadedFileLarge(BandForm model)
        {
            string uniqueFileName = null;
            string fileExtension = null;
            long fileSize = 0;

            if (model.BandImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

                fileExtension = Path.GetExtension(model.BandImage.FileName);
                fileExtension = fileExtension.ToLowerInvariant();
                uniqueFileName = Guid.NewGuid().ToString() + fileExtension;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BandImage.CopyTo(fileStream);
                    fileSize = fileStream.Length;
                }
            }

            return new Tuple<string, string, long>(uniqueFileName, fileExtension, fileSize);
        }

        private Tuple<string, string, long> UploadedFileSmall(BandForm model)
        {
            string uniqueFileName = null;
            string fileExtension = null;
            long fileSize = 0;

         
            if (model.BandImageMobile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");

                fileExtension = Path.GetExtension(model.BandImageMobile.FileName);
                fileExtension = fileExtension.ToLowerInvariant();
                uniqueFileName = Guid.NewGuid().ToString() + fileExtension;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BandImageMobile.CopyTo(fileStream);
                    fileSize = fileStream.Length;
                }
            }

            return new Tuple<string, string, long>(uniqueFileName, fileExtension, fileSize);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddConcert(ConcertForm model)
        {
            if (ModelState.IsValid)
            {
                Concert newConcert = new Concert
                {
                    ConcertID = model.ConcertID,
                    Venue = model.Venue,
                    Address = model.Address,
                    PostCode = model.PostCode,
                    Area = model.Area,
                    Date = model.Date,
                    Time = model.Time,
                    Price = model.Price,
                    RemainingTickets = model.RemainingTickets
                };
                _context.Add(newConcert);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();

        }

        [HttpGet]
        public IActionResult UpdateBand(int id)
        {
            Band model = _context.Bands.Find(id);
            BandForm formModel = new BandForm
            {
                BandID = model.BandID,
                BandTitle = model.BandTitle,
                BandGenre = model.BandGenre,
                BandDescription = model.BandDescription,
                BandPrice = model.BandPrice,
                Stars = model.Stars,
                BandDate = model.BandDate,
                BandArea = model.BandArea
            };
            ViewBag.ImageNameLarge = model.BandImage;
            ViewBag.ImageNameSmall = model.BandImageMobile;
            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBand(BandForm model)
        {
            if (ModelState.IsValid)
            {
                Band editBand = new Band
                {
                    BandID = model.BandID,
                    BandTitle = model.BandTitle,
                    BandGenre = model.BandGenre,
                    BandDescription = model.BandDescription,
                    BandImage = model.BandImageName,
                    BandImageMobile = model.BandImageMobileName,
                    BandPrice = model.BandPrice,
                    Stars = model.Stars,
                    BandDate = model.BandDate,
                    BandArea = model.BandArea
                };
                _context.Bands.Update(editBand);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateBandImageDesktop(int id) 
        {
            Band model = _context.Bands.Find(id);
            BandForm formModel = new BandForm
            {
                BandID = model.BandID,
                BandTitle = model.BandTitle,
                BandGenre = model.BandGenre,
                BandDescription = model.BandDescription,
                BandPrice = model.BandPrice,
                Stars = model.Stars,
                BandDate = model.BandDate,
                BandArea = model.BandArea
            };
            ViewBag.ImageNameLarge = model.BandImage;
            ViewBag.ImageNameSmall = model.BandImageMobile;
            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBandImageDesktop(BandForm model)
        {
            if (model.BandImage != null)
            {
                var tupleLarge = UploadedFileLarge(model);
                string uniqueFileNameLarge = tupleLarge.Item1;
                string fileExtLarge = tupleLarge.Item2;
                long fileSizeLarge = tupleLarge.Item3;
                string[] permittedExtensions = { ".gif", ".jpg", ".jpeg", ".png" };

                // if file is greater than 5 MB
                if (fileSizeLarge > 5000000)
                {
                    ViewBag.msg = "Image Large Too Big: " + fileSizeLarge.ToString();

                    return View();
                }
                // if file is not a whitelisted type
                if (!permittedExtensions.Contains(fileExtLarge))
                {
                    ViewBag.msg = "Wrong File type " + fileExtLarge;
                    return View();
                }

                if (model.BandImageMobileName != null) 
                {
                    Band editBand = new Band
                    {
                        BandID = model.BandID,
                        BandTitle = model.BandTitle,
                        BandGenre = model.BandGenre,
                        BandDescription = model.BandDescription,
                        BandImage = uniqueFileNameLarge,
                        BandImageMobile = model.BandImageMobileName,
                        BandPrice = model.BandPrice,
                        Stars = model.Stars,
                        BandDate = model.BandDate,
                        BandArea = model.BandArea
                    };
                    _context.Bands.Update(editBand);
                } 
                else 
                {
                    Band editBand = new Band
                    {
                        BandID = model.BandID,
                        BandTitle = model.BandTitle,
                        BandGenre = model.BandGenre,
                        BandDescription = model.BandDescription,
                        BandImage = uniqueFileNameLarge,
                        BandPrice = model.BandPrice,
                        Stars = model.Stars,
                        BandDate = model.BandDate,
                        BandArea = model.BandArea
                    };
                    _context.Bands.Update(editBand);
                }

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            if (model.BandImageName != null) 
            {

                Band editBand = new Band
                {
                    BandID = model.BandID,
                    BandTitle = model.BandTitle,
                    BandGenre = model.BandGenre,
                    BandDescription = model.BandDescription,
                    BandImage = model.BandImageName,
                    BandImageMobile = model.BandImageMobileName,
                    BandPrice = model.BandPrice,
                    Stars = model.Stars,
                    BandDate = model.BandDate,
                    BandArea = model.BandArea
                };
                _context.Bands.Update(editBand);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBandImageMobile(int id)
        {
            Band model = _context.Bands.Find(id);
            BandForm formModel = new BandForm
            {
                BandID = model.BandID,
                BandTitle = model.BandTitle,
                BandGenre = model.BandGenre,
                BandDescription = model.BandDescription,
                BandPrice = model.BandPrice,
                Stars = model.Stars,
                BandDate = model.BandDate,
                BandArea = model.BandArea
            };
            ViewBag.ImageNameLarge = model.BandImage;
            ViewBag.ImageNameSmall = model.BandImageMobile;
            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBandImageMobile(BandForm model) 
        {
            if (model.BandImageMobile != null)
            {

                var tupleSmall = UploadedFileSmall(model);
                string uniqueFileNameSmall = tupleSmall.Item1;
                string fileExtSmall = tupleSmall.Item2;
                long fileSizeSmall = tupleSmall.Item3;
                string[] permittedExtensions = { ".gif", ".jpg", ".jpeg", ".png" };

                // if file is greater than 5 MB
                if (fileSizeSmall > 5000000)
                {
                    ViewBag.msg = "Image Small Too Big: " + fileSizeSmall.ToString();

                    return View();
                }
                // if file is not a whitelisted type
                if (!permittedExtensions.Contains(fileExtSmall))
                {
                    ViewBag.msg = "Wrong File type " + fileExtSmall;
                    return View();
                }

                if (model.BandImageName != null)
                {
                    Band editBand = new Band
                    {
                        BandID = model.BandID,
                        BandTitle = model.BandTitle,
                        BandGenre = model.BandGenre,
                        BandDescription = model.BandDescription,
                        BandImage = model.BandImageName,
                        BandImageMobile = uniqueFileNameSmall,
                        BandPrice = model.BandPrice,
                        Stars = model.Stars,
                        BandDate = model.BandDate,
                        BandArea = model.BandArea
                    };
                    _context.Bands.Update(editBand);
                }
                else
                {
                    Band editBand = new Band
                    {
                        BandID = model.BandID,
                        BandTitle = model.BandTitle,
                        BandGenre = model.BandGenre,
                        BandDescription = model.BandDescription,
                        BandImageMobile = uniqueFileNameSmall,
                        BandPrice = model.BandPrice,
                        Stars = model.Stars,
                        BandDate = model.BandDate,
                        BandArea = model.BandArea
                    };
                    _context.Bands.Update(editBand);
                }
                
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            if (model.BandImageMobileName != null)
            {

                Band editBand = new Band
                {
                    BandID = model.BandID,
                    BandTitle = model.BandTitle,
                    BandGenre = model.BandGenre,
                    BandDescription = model.BandDescription,
                    BandImage = model.BandImageName,
                    BandImageMobile = model.BandImageMobileName,
                    BandPrice = model.BandPrice,
                    Stars = model.Stars,
                    BandDate = model.BandDate,
                    BandArea = model.BandArea
                };
                _context.Bands.Update(editBand);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateConcert(int id)
        {
            Concert model = _context.Concerts.Find(id);
            ConcertForm formModel = new ConcertForm
            {
                ConcertID = model.ConcertID,
                Venue = model.Venue,
                Address = model.Address,
                PostCode = model.PostCode,
                Area = model.Area,
                Date = model.Date,
                Time = model.Time,
                Price = model.Price,
                RemainingTickets = model.RemainingTickets
            };
            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateConcert(ConcertForm model)
        {
            if (ModelState.IsValid)
            {
                Concert editConcert = new Concert
                {
                    ConcertID = model.ConcertID,
                    Venue = model.Venue,
                    Address = model.Address,
                    PostCode = model.PostCode,
                    Area = model.Area,
                    Date = model.Date,
                    Time = model.Time,
                    Price = model.Price,
                    RemainingTickets = model.RemainingTickets
                };
                _context.Concerts.Update(editConcert);

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddBandToConcert(int id)
        {
            dynamic model = new System.Dynamic.ExpandoObject();

            var bands = from b in _context.Bands select b;
            List<Band> bandModel = _context.Bands.ToList();

            List<int> concertID = new List<int>() { id };

            model.Band = bandModel;
            model.ConcertID = concertID;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBandToConcert(BandConcert model) 
        {
            _context.BandConcert.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveBandFromConcert(BandConcert model) 
        {
            //_context.BandConcert.Remove(_context.BandConcert.Single(x => x.BandID == bandId && x.ConcertID == concertId)); // delete from the linking table aswell
            _context.BandConcert.Remove(model);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteBand(int Id)
        {
            Band model = _context.Bands.Find(Id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBand(Band model)
        {
            _context.Bands.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteConcert(int Id)
        {

            dynamic model = new System.Dynamic.ExpandoObject();

            var bandConcerts = from l in _context.BandConcert select l;

            if (Id != 0)
            {
                bandConcerts = bandConcerts.Where(x => x.ConcertID == Id);
            }
            List<BandConcert> bandConcertModel = bandConcerts.ToList();

            var concerts = from c in _context.Concerts select c;

            if (Id != 0)
            {
                concerts = concerts.Where(x => x.ConcertID == Id);
            }
            List<Concert> concertModel = concerts.ToList();

            model.Concerts = concertModel;
            model.Link = bandConcertModel;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConcert(Concert model)
        {
            _context.Concerts.Remove(model);

            int id = model.ConcertID;

            _context.BandConcert.Remove(_context.BandConcert.Single(x => x.ConcertID == id)); // delete from the linking table aswell

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}