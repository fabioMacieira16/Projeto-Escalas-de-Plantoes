using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Model;
using System.Data.OleDb;

namespace Agenda.Controller
{
    public class ControleAnalista : Conexao
    {
        public string Gravar(CadastroAnalistas cad)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"INSERT INTO NomeDoAnalista(NomeDoAnalista)
                                        values(?)", Con);
                Cmd.Parameters.AddWithValue("@v1", cad.NomeDoAnalista);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao gravar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "Analista ";
        }
        public string Atualizar(CadastroAnalistas cadAnalista)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"UPDATE NomeDoAnalista 
                                       SET NomeDoAnalista = ?
                                        where Id = ? ", Con);
                Cmd.Parameters.AddWithValue("@v1", cadAnalista.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@v2", cadAnalista.Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao atualizar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "Atualizado com Sucesso ";
        }
        public List<CadastroAnalistas> ListaAnalista()
        {
            AbrirConexao();
            Cmd = new OleDbCommand("Select * from NomeDoAnalista", Con);
            Dr = Cmd.ExecuteReader();

            List<CadastroAnalistas> Listar = new List<CadastroAnalistas>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        CadastroAnalistas cadAnalista = new CadastroAnalistas();
                        cadAnalista.Id = Convert.ToInt16(Dr["Id"]);
                        cadAnalista.NomeDoAnalista = Dr.GetString(Dr.GetOrdinal("NomeDoAnalista"));
                        Listar.Add(cadAnalista);
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        public void Exluir(int id)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand("Delete from NomeDoAnalista Where ID = ? ", Con);
                Cmd.Parameters.AddWithValue("@v1", id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao excluir os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        
    }
}
