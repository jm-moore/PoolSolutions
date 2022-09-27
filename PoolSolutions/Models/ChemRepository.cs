using Dapper;
using System.Data;

namespace PoolSolutions.Models
{
    public class ChemRepository : IChemRepository
    {
        private readonly IDbConnection _conn;
        public ChemRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Chem> GetAllChems()
        {
            return _conn.Query<Chem>("SELECT * FROM CHEMS;");
        }
        public Chem GetChem(int id)
        {
            return _conn.QuerySingle<Chem>("SELECT * FROM CHEMS WHERE PoolID = @id", new { id = id });
        }
        public void UpdateChem(Chem chem)
        {
            _conn.Execute("UPDATE chems SET PH = @PH, Chlorine = @Chlorine, Bromine = @Bromine, Alkalinity = @Alkalinity, Stabilizer = @Stabilizer WHERE PoolID = @PoolID",
             new { PH = chem.PH, Chlorine = chem.Chlorine, Bromine = chem.Bromine, Alkalinity = chem.Alkalinity, Stabilizer = chem.Stabilizer, PoolID = chem.PoolID });
        }
    }
}
