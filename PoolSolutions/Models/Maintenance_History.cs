namespace PoolSolutions.Models
{
    public class Maintenance_History
    {
        public Maintenance_History()
        {

        }
        public string action { get; set; }
        public int revision { get; set; }
        public DateTime dt_datetime { get; set; }
        public int PoolID { get; set; }
        public string CleanDate { get; set; }
        public bool Vacuumed { get; set; }
        public bool Brushed { get; set; }
        public bool Skimmed { get; set; }
        public bool Backwashed { get; set; }
        public bool Addedwater { get; set; }
    }
}
