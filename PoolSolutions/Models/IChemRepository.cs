namespace PoolSolutions.Models
{
    public interface IChemRepository
    {
        public IEnumerable<Chem> GetAllChems();
        public Chem GetChem(int id);
        public void UpdateChem(Chem chem);
    }
}
