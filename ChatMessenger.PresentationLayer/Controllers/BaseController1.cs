using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatMessenger.BusinessLogicLayer.Factories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatMessenger.PresentationLayer.Controllers
{
    public class BaseController1 : Controller
    {
        protected readonly AbstractFactory _blFactory;
    }
}
