using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {

        private readonly ToDoDbContext _context;

        public ToDoController(ToDoDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var allElements = _context.Elements.ToList();
            return View(allElements);
        }

        // Own code

        public IActionResult AddEditToDo()
        {
            return View();
        }

        public IActionResult AddEditToDoForm(ToDoElement element)
        {
            if (element.Id == 0)
            {
                _context.Elements.Add(element);
            }
            else
            {
                _context.Elements.Update(element);
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
