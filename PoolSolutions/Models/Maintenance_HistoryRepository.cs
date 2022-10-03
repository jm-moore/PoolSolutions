using Dapper;
using System.Data;

namespace PoolSolutions.Models
{
    public class Maintenance_HistoryRepository : IMaintenance_HistoryRepository
    {
        private readonly IDbConnection _conn;
        public Maintenance_HistoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Maintenance_History> GetAllMaintenance_Histories()
        {
            return _conn.Query<Maintenance_History>("SELECT * FROM Maintenance_History;");
        }
        public Maintenance_History GetMaintenance_History(int id)
        {
            return _conn.QuerySingle<Maintenance_History>("SELECT * FROM Maintenance_History WHERE POOLID = @id", new { id = id });
        }
    }
}
