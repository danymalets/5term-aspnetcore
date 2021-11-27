using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WEB_953501_MALETS.Data;
using WEB_953501_MALETS.Entities;
using WEB_953501_MALETS.Extensions;
using WEB_953501_MALETS.Models;

namespace WEB_953501_MALETS.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        
        int _pageSize;
        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }
        
        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo=1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo,
                _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
    }
}