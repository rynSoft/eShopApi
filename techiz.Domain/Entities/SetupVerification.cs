using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace techiz.Domain.Entities
{
    public class SetupVerification : BaseSimpleModel
    {
        public SetupVerification()
        {
            Active = true;
        }
        public int ProductionId { get; set; }
        public virtual Production Production { get; set; } 
        
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; } 
        public bool Active { get; set; }
        
        public virtual ICollection<SetupVerificationDetails> SetupVerificationDetails { get; set; }
        public virtual ICollection<ProductionOperations> ProductionOperations { get; set; }
        

    }
}