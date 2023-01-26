using Microsoft.AspNetCore.Mvc;
using Northwind.Api.Models;
using System.Diagnostics;

namespace Northwind.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //WebApiClient<Category> apiClient = new WebApiClient<Category>();
            //var result = await apiClient.Get(ApiUrl.Categories + "1");
            //Category category = new Category { id = 0, name = "Tekstil", description = "Giyim kusam" };
            //var result = await apiClient.Post(ApiUrl.Categories, category);


            return View();
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