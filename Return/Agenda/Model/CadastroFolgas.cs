using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class CadastroFolgas
    {
        public int Id { get; set; }
        public string NomeDoAnalista { get; set; }
        public DateTime DataTrabalhada { get; set; }
        public DateTime DataDaFolga { get; set; }
        public string Obervacao { get; set; }
    }
}
