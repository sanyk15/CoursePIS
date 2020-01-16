using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Tour
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Duration { get; set; }
        [DataMember]
        public double Cost { get; set; }
        [DataMember]
        public string Service { get; set; }

        [ForeignKey("TourId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}