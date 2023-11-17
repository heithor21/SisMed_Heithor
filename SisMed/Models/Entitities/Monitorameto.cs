using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisMed.Models.Entitities
{
    public class Monitorameto
    {
        public int Id { get; set; }
        public string? Pressaoarterial { get; set; }
        public decimal Temperatura { get; set; }
        public int SaturacaoOxigenio { get; set; }
        public int FrequenciaCardica { get; set; }
        public DateTime DataAfericao { get; set; }
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; } = null!;
    }
}