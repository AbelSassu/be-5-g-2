using be_5_g_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace be_5_g_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Db.getAll());
        }
        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                return View(Db.getByID(id));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string nome, string cognome, string indirizzo, string codiceFiscale, bool coniugato, int figli, string mansione)
        {
            var dipendente = Db.AggiungiDipendente(nome, cognome, indirizzo, codiceFiscale, coniugato, figli, mansione);
            return RedirectToAction("Details", new {id = dipendente.DipendenteId });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
