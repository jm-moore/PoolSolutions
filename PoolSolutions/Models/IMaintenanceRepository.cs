namespace PoolSolutions.Models
{
    public interface IMaintenanceRepository
    {
        public IEnumerable<Maintenance> GetAllMaintenances();
        public Maintenance GetMaintenance(int id);
        public void UpdateMaintenance(Maintenance maintenance);
    }
}
