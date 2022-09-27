namespace PoolSolutions.Models
{
    public class Chem
    {
        public Chem()
        {

        }
        public int PoolID { get; set; }
        public double PH { get; set; }
        public double Chlorine { get; set; }
        public int Bromine { get; set; }
        public int Alkalinity { get; set; }
        public int Stabilizer { get; set; }
    }
}
