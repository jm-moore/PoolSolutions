namespace PoolSolutions.Models
{
    public class Chem_History
    {
        public Chem_History()
        {

        }
        public string Action { get; set; }
        public int Revision { get; set; }
        public DateTime dt_datetime { get; set; }
        public int PoolID { get; set; }
        public double PH { get; set; }
        public double Chlorine { get; set; }
        public int Bromine { get; set; }
        public int Alkalinity { get; set; }
        public int Stabilizer { get; set; }
    }
}
