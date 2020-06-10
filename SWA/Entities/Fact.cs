namespace SWA.Entities
{
    public class Fact
    {
        public int FactId { get; set; }
        public string FactName { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
