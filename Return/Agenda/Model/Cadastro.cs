using System;

namespace Agenda.Model
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string NomeContato { get; set; }
        public string NomeDaEmpresa { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public DateTime DataDaLigacao { get; set; }
        public String NomeDoAnalista { get; set; }
        public bool StatusRetorno { get; set; }
        public string Observacao { get; set; }

    }
}
