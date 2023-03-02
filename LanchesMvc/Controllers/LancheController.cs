using LanchesMvc.Repositories.Interfaces;
using LanchesMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMvc.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();

            //ViewBag.TotalLanches = totalLanches;

            //return View(lanches);

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);
        }
    }
}
