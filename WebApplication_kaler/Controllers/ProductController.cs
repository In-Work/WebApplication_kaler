using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_kaler.DAL.Entities;
using WebApplication_kaler.Extensions;
using WebApplication_kaler.Models;
using WebApplication_kaler.DAL.Data;
using Microsoft.Extensions.Logging;

namespace WebApplication_kaler.Controllers
{
    public class ProductController : Controller
    {

        ApplicationDbContext _context;
        int _pageSize;
        private ILogger _logger;
        public ProductController(ApplicationDbContext context/*, ILogger<ProductController> logger*/)
        {
            _pageSize = 3;
            _context = context;
            //_logger = logger;
        }




        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo = 1)
        {


            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);

            // Поместить список групп во ViewData
            ViewData["Groups"] = _context.DishGroups;

            // Получить id текущей группы и поместить в TempData
            ViewData["CurrentGroup"] = group ?? 0;

            //_logger.LogInformation($"info: group={group}, page={pageNo}");

            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);

            else
                return View(model);
        }
        
    }
}
