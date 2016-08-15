using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class CadastroKm
    {
        public int Id { get; set; }
        public string NomeDoAnalista { get; set; }
        public string NomeDaEmpresa { get; set; }
        public double Km { get; set; }
        public DateTime DataDaVisita { get; set; }
        public string Observacao { get; set; }
    }
}
