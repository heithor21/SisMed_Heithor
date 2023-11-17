using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace SisMed.Models.Entitities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? CPF { get; set; }
        public InforacoesComplementares? inforacoesComplementares { get; set; }
        public ICollection<Monitorameto> Monitorameto { get; set; } = null!;
        public ICollection<Consulta> Consulta { get; set; } = null!;
    }
}