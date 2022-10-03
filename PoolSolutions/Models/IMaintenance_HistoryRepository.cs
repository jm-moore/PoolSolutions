namespace PoolSolutions.Models
{
    public interface IMaintenance_HistoryRepository
    {
        public IEnumerable<Maintenance_History> GetAllMaintenance_Histories();

        public Maintenance_History GetMaintenance_History(int id);
    }
}
