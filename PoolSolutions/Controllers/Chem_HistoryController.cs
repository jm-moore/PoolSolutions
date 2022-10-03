using Microsoft.AspNetCore.Mvc;
using PoolSolutions.Models;

namespace PoolSolutions.Controllers
{
    public class Chem_HistoryController : Controller
    {
        private readonly IChem_HistoryRepository repo;

        public Chem_HistoryController(IChem_HistoryRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var chem_History = repo.GetAllChem_Histories();
            return View(chem_History);
        }

        public IActionResult ViewChem_History(int id)
        {
            var chemHistory = repo.GetChem_History(id);
            return View(chemHistory);
        }
    }
}
