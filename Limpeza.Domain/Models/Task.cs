using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limpeza.Domain.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Active { get; set; }
        public bool Mandatory { get; set; }
        
        public Quest Quest { get; set; }
    }
}
