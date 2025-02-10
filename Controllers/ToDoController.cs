using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        // Own code

        public IActionResult ToDoList()
        {
            return View();
        }

        public IActionResult AddEditToDo()
        {
            return View();
        }

        public IActionResult AddEditToDoForm()
        {
            return RedirectToAction("ToDoList");
        }

        //


    }
}
