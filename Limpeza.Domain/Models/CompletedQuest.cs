using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limpeza.Domain.Models
{
    public class CompletedQuest
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        
        public User WhoDid { get; set; }
        public Quest Quest { get; set; }
    }
}