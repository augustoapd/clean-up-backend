using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limpeza.Domain.Models
{
    public class Quest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Frequency { get; set; }
        public DateTime Date { get; set; }
        
        public Room Room { get; set; }
        public IEnumerable<Task> Tasks { get; set; }

        public IEnumerable<CompletedQuest> CompletedQuests { get; set; }


    }
}