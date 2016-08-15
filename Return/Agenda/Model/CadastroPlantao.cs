using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class CadastroPlantao
    {
        public int Id { get; set; }
        public string NomeDoAnalista { get; set; }
        public DateTime DataDoPlantao { get; set; }
        public Decimal Valor { get; set; }
        public Decimal ValorTotal { get; set; }
        public string Observacao { get; set; }

    }
}
