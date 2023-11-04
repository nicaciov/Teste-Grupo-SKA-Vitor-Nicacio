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

        [HttpPost]
        public IActionResult FormularioNovaNota(string nota)
        {

            BlocoNotas blocoNotas = new BlocoNotas();

            var dataHora = new DateTime();
            dataHora = DateTime.Now;

            blocoNotas.NOTA = nota;
            blocoNotas.STATUS = 1;
            blocoNotas.DATA_INCLUSAO = dataHora; 

            _iblocoNotasRepository.Salvar(blocoNotas);
                         
            return RedirectToAction("Index", "Home");
        }

        public IActionResult FormularioEditarNota(int id)
        {

            BlocoNotas blocoNotas = _iblocoNotasRepository.Buscar(id);

            if(blocoNotas.STATUS == 1)
            {
                blocoNotas.STATUS = 0;
            } else
            {
                blocoNotas.STATUS = 1;
            }

            _iblocoNotasRepository.Atualizar(blocoNotas);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult FormularioExcluirNota(int id)
        {

            _iblocoNotasRepository.Apagar(id);

            return RedirectToAction("Index", "Home");
        }

    }
}