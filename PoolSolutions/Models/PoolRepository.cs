using Dapper;
using System.Data;

namespace PoolSolutions.Models
{
    public class PoolRepository : IPoolRepository
    {
        private readonly IDbConnection _conn;
        public PoolRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Pool> GetAllPools()
        {
            return _conn.Query<Pool>("SELECT * FROM POOLS;");
        }

        public Pool GetPool(int id)
        {
          return _conn.QuerySingle<Pool>("SELECT * FROM POOLS WHERE PoolID = @id", new { id = id });
        }

        public void UpdatePool(Pool pool)
        {
            _conn.Execute("UPDATE pools SET PoolLocation = @PoolLocation, PoolType = @PoolType WHERE PoolID = @id",
              new { PoolLocation = pool.PoolLocation, PoolType = pool.PoolType, id = pool.PoolID });
        }
        public void InsertPool(Pool poolToInsert)
        {
            _conn.Execute("INSERT INTO pools (PoolID, PoolLocation, PoolType) VALUES (@PoolID, @PoolLocation, @PoolType);",
                new { PoolID = poolToInsert.PoolID, PoolLocation = poolToInsert.PoolLocation, PoolType = poolToInsert.PoolType});
        }
        public void DeletePool(int PoolID)
        {
            _conn.Execute("DELETE FROM POOLS WHERE PoolID = @id;", new { id = PoolID });
            _conn.Execute("DELETE FROM CHEMS WHERE PoolID = @id;", new { id = PoolID });
            _conn.Execute("DELETE FROM MAINTENANCE WHERE PoolID = @id;", new { id = PoolID });
        }
    }
}
