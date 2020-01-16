using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class TableStatement
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int AgentId { get; set; }
        [DataMember]
        public double Sum { get; set; }
        [DataMember]
        public int StatementId { get; set; }

        public virtual AgentContract Agent { get; set; }
        public virtual Statement Statement { get; set; }
    }
}