using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.Models.Entitities
{
    public class Medico
    {
        public int Id { get; set; }
        public string? CRM { get; set; }
        public string? Nome { get; set; }
    }
}