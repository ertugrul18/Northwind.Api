using Microsoft.AspNetCore.Mvc;
using Northwind.Api.Models;

namespace Northwind.Api.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            WebApiClient<Category> apiClient = new WebApiClient<Category>();
            var result = await apiClient.GetAll(ApiUrl.Categories);
            //Category category = new Category { id = 0, name = "Tekstil", description = "Giyim kusam" };
            //var result = await apiClient.Post(ApiUrl.Categories, category);


            return View(result);
        }
    }
}
