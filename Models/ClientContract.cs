namespace Models
{
    public class ClientContract
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int ClientId { get; set; }
        public int TourId { get; set; }
        public int NumberPeople { get; set; }
        public string Date { get; set; }
        public string Total { get; set; }

        public virtual User Agent { get; set; }
        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
    }
}