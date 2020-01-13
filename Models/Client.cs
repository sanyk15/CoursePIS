using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Passport { get; set; }

        [ForeignKey("ClientId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}