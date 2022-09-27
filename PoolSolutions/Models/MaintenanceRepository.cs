using Dapper;
using System.Data;

namespace PoolSolutions.Models
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        private readonly IDbConnection _conn;
        public MaintenanceRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Maintenance> GetAllMaintenances()
        {
            return _conn.Query<Maintenance>("SELECT * FROM MAINTENANCE;");
        }
        public Maintenance GetMaintenance(int id)
        {
            return _conn.QuerySingle<Maintenance>("SELECT * FROM MAINTENANCE WHERE PoolID = @id", new { id = id });
        }
        public void UpdateMaintenance(Maintenance maintenance)
        {
            _conn.Execute("UPDATE maintenance SET CleanDate = @CleanDate, Vacuumed = @Vacuumed, Brushed = @Brushed, Skimmed = @Skimmed, Backwashed = @Backwashed, Addedwater = @Addedwater WHERE PoolID = @PoolID",
             new { CleanDate = maintenance.CleanDate, Vacuumed = maintenance.Vacuumed, Brushed = maintenance.Brushed, Skimmed = maintenance.Skimmed, Backwashed = maintenance.Backwashed, Addedwater = maintenance.Addedwater, PoolID = maintenance.PoolID });
        }
    }
}
