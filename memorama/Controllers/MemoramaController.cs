using Microsoft.AspNetCore.Mvc;
using Memorama.Models;

namespace Memorama.Controllers
{
    public class MemoramaController : Controller
    {
        public IActionResult Index()
        {
            var modelo = new MemoramaModel().GenerarTablero();
            return View(modelo);
        }
    }
}
