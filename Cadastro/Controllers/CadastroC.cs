using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Cadastro.Controllers
{
    public class CadastroC : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult criar()
        {
            return View();
        }
        public IActionResult editar()
        {
            return View();

        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
    }
}
