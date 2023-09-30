using Buybook.Data;
using Buybook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buybook.Controllers
{
	public class CategoryController : Controller
	{
        private readonly BookDbContext _Db;
        public CategoryController(BookDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            List<Category> objlist = _Db.categories.ToList();
            return View(objlist);
        }
    }
}
