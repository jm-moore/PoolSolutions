using Dapper;
using System.Data;

namespace PoolSolutions.Models
{
    public class Chem_HistoryRepository : IChem_HistoryRepository
    {
        private readonly IDbConnection _conn;
        public Chem_HistoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Chem_History> GetAllChem_Histories()
        {
            return _conn.Query<Chem_History>("SELECT * FROM CHEMS_HISTORY;");
        }

        public Chem_History GetChem_History(int id)
        {
            return _conn.QuerySingle<Chem_History>("SELECT * FROM CHEMS_HISTORY WHERE PoolID = @id", new { id = id });
        }
    }
}
