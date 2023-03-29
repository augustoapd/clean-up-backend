using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Limpeza.Domain.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}