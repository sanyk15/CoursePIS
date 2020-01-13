namespace Models
{
    public class TableStatement
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public double Sum { get; set; }
        public int StatementId { get; set; }

        public virtual User Agent { get; set; }
        public virtual Statement Statement { get; set; }
    }
}