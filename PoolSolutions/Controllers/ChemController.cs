using Microsoft.AspNetCore.Mvc;
using PoolSolutions.Models;

namespace PoolSolutions.Controllers
{
    public class ChemController : Controller
    {
        private readonly IChemRepository repo;

        public ChemController(IChemRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var chems = repo.GetAllChems();
            return View(chems);
        }
        public IActionResult ViewChem(int id)
        {
            var chem = repo.GetChem(id);
            return View(chem);
        }
        public IActionResult UpdateChem(int id)
        {
            Chem chem = repo.GetChem(id);
            if (chem == null)
            {
                return View("ChemNotFound");
            }
            return View(chem);
        }
        public IActionResult UpdateChemToDatabase(Chem chem)
        {
            repo.UpdateChem(chem);

            return RedirectToAction("ViewChem", new { id = chem.PoolID });
        }
    }
}
