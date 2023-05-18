using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.DataContext;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly MedicioDataContex _medicioDataContex;
        public HomeController(MedicioDataContex medicioDataContex)
        {
            _medicioDataContex = medicioDataContex;
        }

        public async Task< IActionResult> Index()
        {
            List<Service> services = await _medicioDataContex.Services.ToListAsync();


            return View(services);
        }
    }
}
