using Microsoft.AspNetCore.Mvc;
using TCC_BUGGY;
using TCC_BUGGY.Data;
using TCC_BUGGY.Services;
using TCC_BUGGY.Models;
using TCC_BUGGY.Models.ViewModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TCC_BUGGY.Controllers
{
    public class AtendimentosController : Controller
    {


        private readonly AtendimentoService _atendimentoService;
        private readonly OcorrenciaService _ocorrenciaServices;

        public AtendimentosController (AtendimentoService atendimentoService, OcorrenciaService ocorrenciaService)
        {
            _atendimentoService = atendimentoService;
            _ocorrenciaServices = ocorrenciaService;

        }



        public IActionResult Index()
        {
            var list = _atendimentoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var ocorrencias = _ocorrenciaServices.FindAll();
            var viewModel = new AtendimentoFormViewModel { Ocorrencias = ocorrencias };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Atendimento atendimento)
        {
            _atendimentoService.Insert(atendimento);
            return RedirectToAction(nameof(Index));
        }





    }
}
