using Microsoft.AspNetCore.Mvc;
using PoolSolutions.Models;

namespace PoolSolutions.Controllers
{
    public class PoolController : Controller
    {

        private readonly IPoolRepository repo;

        public PoolController(IPoolRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var pool = repo.GetAllPools();
            return View(pool);
        }
        public IActionResult ViewPool(int id)
        {
            var pool = repo.GetPool(id);
            return View(pool);
        }
        public IActionResult UpdatePool(int id)
        {
            Pool pool = repo.GetPool(id);
            if (pool == null)
            {
                return View("PoolNotFound");
            }
            return View(pool);
        }
        public IActionResult UpdatePoolToDatabase(Pool pool)
        {
            repo.UpdatePool(pool);

            return RedirectToAction("ViewPool", new { id = pool.PoolID });
        }
        public IActionResult InsertPool()
        {
            var pool = new Pool();
            return View(pool);
        }
        public IActionResult InsertPoolToDatabase(Pool poolToInsert)
        {
            repo.InsertPool(poolToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePool(int id)
        {
            repo.DeletePool(id);
            return RedirectToAction("Index");
        }
    }
}
