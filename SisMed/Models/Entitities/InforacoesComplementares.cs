using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.Models.Entitities
{
    public class InforacoesComplementares
    {
        public int Id { get; set; }
        public string? Alergias { get; set; }
        public string? MedicamentosEmUso { get; set; }
        public string? CirugiasRealizadas  { get; set; }
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; } = null!;
    }
}