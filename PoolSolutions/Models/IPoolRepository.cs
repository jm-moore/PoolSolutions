namespace PoolSolutions.Models
{
    public interface IPoolRepository
    {
        public IEnumerable<Pool> GetAllPools();

        public Pool GetPool(int id);

        public void UpdatePool (Pool pool);

        public void InsertPool(Pool poolToInsert);
        public void DeletePool(int PoolID);
    }
}
