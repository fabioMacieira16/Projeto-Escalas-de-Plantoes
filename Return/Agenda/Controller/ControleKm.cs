using System;
using MetroFramework;
using MetroFramework.Forms;
using Agenda.Controller;
using Agenda.Model;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Agenda.Controller
{
    public class ControleKm : Conexao
    {
        public string Gravar(CadastroKm km)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand(@"INSERT INTO ControleCombustivel(NomeDoAnalista, NomeDaEmpresa, Km, DataDaVisita, Observacao)
                                                                        VALUES (?,?,?,?,?) ", Con);
                Cmd.Parameters.AddWithValue("@v1", km.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@v2", km.NomeDaEmpresa);
                Cmd.Parameters.AddWithValue("@v3", km.Km);
                Cmd.Parameters.AddWithValue("@V4", km.DataDaVisita);
                Cmd.Parameters.AddWithValue("@v5", km.Observacao);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao Gravar a Quilometragem " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "";
        }

        public List<CadastroKm> ListarKm ()
        {
            AbrirConexao();
            Cmd = new OleDbCommand(@"Select * From ControleCombustivel ", Con);
            Dr = Cmd.ExecuteReader();
            List<CadastroKm> listarKm = new List<CadastroKm>();
            try
            {
                while (Dr.Read())
                {
                    CadastroKm cadkm = new CadastroKm();
                    cadkm.Id = Convert.ToInt16(Dr["Id"]);
                    cadkm.NomeDoAnalista = Dr.GetString(Dr.GetOrdinal("NomeDoAnalista"));
                    cadkm.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                    cadkm.Km = Convert.ToDouble(Dr["Km"]);
                    cadkm.DataDaVisita = Convert.ToDateTime(Dr["DataDaVisita"]);
                    cadkm.Observacao = Convert.ToString(Dr["Observacao"]);
                    listarKm.Add(cadkm);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro na lista de Quilometragem " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return listarKm;
        }

    }
}
