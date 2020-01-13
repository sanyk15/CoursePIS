using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        [ForeignKey("AgentId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
        [ForeignKey("AgentId")]
        public virtual List<AgentContract> AgentContracts { get; set; }
        [ForeignKey("AccountantId")]
        public virtual List<Statement> Statements { get; set; }
        [ForeignKey("AgentId")]
        public virtual List<TableStatement> TableStatements { get; set; }
    }
}