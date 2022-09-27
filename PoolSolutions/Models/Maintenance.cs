namespace PoolSolutions.Models
{
    public class Maintenance
    {
        public Maintenance()
        {

        }
        public int PoolID { get; set; }
        public string CleanDate { get; set; }
        public bool Vacuumed { get; set; }
        public bool Brushed { get; set; }
        public bool Skimmed { get; set; }
        public bool Backwashed { get; set; }
        public bool Addedwater { get; set; }
    }
}
