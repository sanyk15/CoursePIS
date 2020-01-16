using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class ClientContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int AgentId { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int TourId { get; set; }
        [DataMember]
        public int NumberPeople { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public double Total { get; set; }

        public virtual AgentContract Agent { get; set; }
        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
    }
}