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
            _conn.Execute("UPDATE pools SET Location = @PoolLocation, Type = @PoolType WHERE PoolID = @id",
              new { Location = pool.PoolLocation, Type = pool.PoolType, id = pool.PoolID });
        }
    }
}
