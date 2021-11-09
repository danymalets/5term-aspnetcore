using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB_953501_MALETS.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemo> _listDemo;

        [ViewData] public string Text { get; set; }
        [ViewData] public SelectList Lst { get; set; }
        
        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue=1, ListItemText="Item 1"},
                new ListDemo{ ListItemValue=2, ListItemText="Item 2"},
                new ListDemo{ ListItemValue=3, ListItemText="Item 3"}
            };
        }
        
        public IActionResult Index()
        {
            Text = "Лабораторная работа 2";
            Lst = new SelectList(_listDemo,"ListItemValue","ListItemText");
            return View();
        }
    }
    
    public class ListDemo
    {
        public int ListItemValue { get; set; }
        public string ListItemText { get; set; }
    }
}