using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace ControllerView.Controllers
{
    public class LearningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET: /Learning/
        //public string Index()
        //{
        //    return "This is my default learning action...";
        //}

        //GET: /Learning/Welcome/
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");
        //}
    }
}
