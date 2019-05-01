using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ManagerWeb.Controllers
{
    public class ModelBuilderTemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}