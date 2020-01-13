namespace Models
{
    public class AgentContract
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string Date { get; set; }
        public double Commission { get; set; }
        public bool Status { get; set; }

        public virtual User Agent { get; set; }
    }
}