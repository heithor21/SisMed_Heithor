using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.Models.Entitities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; } 
        public string? Tipo { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
        public Paciente Paciente { get; set; } = null!;
        public Medico Medico { get; set; } = null!;
    }
}