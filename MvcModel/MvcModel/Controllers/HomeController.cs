using Microsoft.AspNetCore.Mvc;
using MvcModel.Models;
using System.Diagnostics;

namespace MvcModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebMaster _webmaster;
        private readonly WebMaster _webmaster1;
        private readonly List<WebMaster> _webMasters;

        public HomeController(ILogger<HomeController> logger, WebMaster webmaster, List<WebMaster> webMasters, WebMaster webmaster1)
        {
            _logger = logger;
            _webmaster = webmaster;
            _webMasters = webMasters;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {   
            //1.yol ViewBag
           
            _webmaster.Ad = "Şamil";
            _webmaster.Mail = "abscsa.com";
            _webmaster.id = 1;
            _webmaster.Soyad = "Yılmaz";
            ViewBag.id= _webmaster.id;
            ViewBag.Ad= _webmaster.Ad;
            ViewBag.Soyad= _webmaster.Soyad;
            ViewBag.Mail= _webmaster.Mail;

            //1.yol B ViewBag 
           
            return View(_webmaster);
        }
        public IActionResult Contact2()
        {
            
            _webmaster.Ad = "Şamil";
            _webmaster.Mail = "abscsa.com";
            _webmaster.id=1;
            _webmaster.Soyad = "Yılmaz";

            return View();
        }
        public IActionResult PersonelListe(ILogger<HomeController> logger, WebMaster webmaster, List<WebMaster> webMasters, WebMaster webmaster1)
        {
           
          
            _webmaster.Ad = "Şamil";
            _webmaster.Mail = "abscsa.com";
            _webmaster.id = 1;
            _webmaster.Soyad = "Yılmaz";
            _webMasters.Add(_webmaster);


            _webmaster1.Ad = "Ahmet";
            _webmaster1.Mail = "abscasasa.com";
            _webmaster1.id = 2;
            _webmaster1.Soyad = "Yılmaz";
            _webMasters.Add(_webmaster1);
            ViewBag.Liste = _webMasters;


            return View(_webmaster);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}