using Microsoft.AspNetCore.Mvc;
using PoolSolutions.Models;

namespace PoolSolutions.Controllers
{
    public class Maintenance_HistoryController : Controller
    {
        private readonly IMaintenance_HistoryRepository repo;
        public Maintenance_HistoryController(IMaintenance_HistoryRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var maintenance_Histories = repo.GetAllMaintenance_Histories();
            return View(maintenance_Histories);
        }
        public IActionResult ViewMaintenance_History(int id)
        {
            var maintenanceHistory = repo.GetMaintenance_History(id);
            return View(maintenanceHistory);
        }
    }
}
