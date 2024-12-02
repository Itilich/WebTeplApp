using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTeplApp.Data;
using WebTeplApp.Models;

namespace WebTeplApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TeplAppContext _context;

        public HomeController(ILogger<HomeController> logger, TeplAppContext context)
        {
            _logger = logger;
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var varisants = _context.Variants.ToList();

            return View(varisants);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var variant = _context.Variants.FirstOrDefault(x => x.Id == id);

            if (variant != null)
            {
                _context.Variants.Remove(variant);
                _context.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Table(int id)
        {
            var variant = _context.Variants.FirstOrDefault(x => x.Id == id);
            var viewModel = new HomeCalcViewModel();

            if (variant != null)
            {
                viewModel.Num1 = variant.Num1;
                viewModel.Num2 = variant.Num2;
                viewModel.Num3 = variant.Num3;
                viewModel.Num4 = variant.Num4;
                viewModel.Num5 = variant.Num5;
                viewModel.Num6 = variant.Num6;
                viewModel.Num7 = variant.Num7;
                viewModel.Num8 = variant.Num8;
                viewModel.Num9 = variant.Num9;

            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Calc(int id)
        { 
            var variant =  _context.Variants.FirstOrDefault(x => x.Id == id);
            var viewModel = new HomeCalcViewModel();

            if (variant != null)
            { 
                viewModel.Num1 = variant.Num1;
                viewModel.Num2 = variant.Num2;
                viewModel.Num3 = variant.Num3;
                viewModel.Num4 = variant.Num4;
                viewModel.Num5 = variant.Num5;
                viewModel.Num6 = variant.Num6;
                viewModel.Num7 = variant.Num7;
                viewModel.Num8 = variant.Num8;
                viewModel.Num9 = variant.Num9;

            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Calc(CalcModel model)
        {

            var viewModel = new HomeCalcViewModel()
            {
            };

            _context.Variants.Add(new Variant 
            { 
                Num1 = model.Num1,
                Num2 = model.Num2,
                Num3 = model.Num3,
                Num4 = model.Num4,
                Num5 = model.Num5,
                Num6 = model.Num6,
                Num7 = model.Num7,
                Num8 = model.Num8,
                Num9 = model.Num9,

            });
            _context.SaveChanges();

            return View(viewModel);
        }
        [HttpGet]
       

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
