using Microsoft.AspNetCore.Mvc;
using _2024_08E_Web_App.Data;
using _2024_08E_Web_App.Models;



namespace _2024_08E_Web_App.Controllers
{

    public class VoucharController : Controller
    {
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        private readonly ApplicationDbContext _context;

        public VoucharController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult create(Vouchar model)
        {

            //model.Id = 1;
            model.Status = "paid";
            _context.Vouchers.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Generate Vochar Successfullt";
            ViewBag.Showpreview = true;
            ViewBag.ShowData = model;
            ModelState.Clear();
            return View(new Vouchar());
        }
    }
}
