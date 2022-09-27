using Microsoft.AspNetCore.Mvc;
using PoolSolutions.Models;

namespace PoolSolutions.Controllers
{
    public class MaintenanceController : Controller
    {
        private readonly IMaintenanceRepository repo;

        public MaintenanceController(IMaintenanceRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var maintenances = repo.GetAllMaintenances();
            return View(maintenances);
        }
        public IActionResult ViewMaintenance(int id)
        {
            var maintenance = repo.GetMaintenance(id);
            return View(maintenance);
        }
        public IActionResult UpdateMaintenance(int id)
        {
            Maintenance maintenance = repo.GetMaintenance(id);
            if (maintenance == null)
            {
                return View("MaintenancesNotFound");
            }
            return View(maintenance);
        }
        public IActionResult UpdateMaintenanceToDatabase(Maintenance maintenance)
        {
            repo.UpdateMaintenance(maintenance);

            return RedirectToAction("ViewMaintenance", new { id = maintenance.PoolID });
        }

    }
}
