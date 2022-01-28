using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvogadosTop.Controllers
{
    public class ClientePessoaJuridicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
