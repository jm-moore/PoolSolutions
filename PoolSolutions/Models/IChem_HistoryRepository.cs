namespace PoolSolutions.Models
{
    public interface IChem_HistoryRepository
    {
        public IEnumerable<Chem_History> GetAllChem_Histories();

        public Chem_History GetChem_History(int id);
    }
}
