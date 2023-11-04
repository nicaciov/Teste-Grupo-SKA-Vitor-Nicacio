using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Teste_Grupo_SKA_Vitor_Nicacio.Models;
using Teste_Grupo_SKA_Vitor_Nicacio.Repository;

namespace Teste_Grupo_SKA_Vitor_Nicacio.Controllers
{
    public class HomeController : Controller
    {

        private readonly IBlocoNotasRepository _iblocoNotasRepository;

        public HomeController(IBlocoNotasRepository iblocoNotasRepository)
        {
            _iblocoNotasRepository = iblocoNotasRepository;
        }

        public IActionResult Index()
        {
            List<BlocoNotas> listaNotas = _iblocoNotasRepository.Listar();

            return View(listaNotas);
        }

    }
}