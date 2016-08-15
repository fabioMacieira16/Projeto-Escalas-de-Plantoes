using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Model;
using System.Data.OleDb;

namespace Agenda.Controller
{
    public class ControleFolgas : Conexao
    {
        public string gravar(CadastroFolgas cadFolgas)
        {
            AbrirConexao();

            try
            {
                Cmd = new OleDbCommand(@"INSERT INTO EscalaDeFolgas(NomeDoAnalista, DataTrabalhada, DataDaFolga,Observacao) values (?,?,?,?) ", Con);
                Cmd.Parameters.AddWithValue("@v1", cadFolgas.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@v2", cadFolgas.DataTrabalhada);
                Cmd.Parameters.AddWithValue("@v3", cadFolgas.DataDaFolga);
                Cmd.Parameters.AddWithValue("@v4", cadFolgas.Obervacao);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw new Exception("Erro as gravar a Folga" + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "";
        }
    }
}
