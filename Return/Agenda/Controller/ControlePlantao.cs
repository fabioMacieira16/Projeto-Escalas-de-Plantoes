using System;
using Agenda.Model;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Agenda.Controller
{
    public class ControlePlantao : Conexao
    {
        public string Gravar(CadastroPlantao cadplan)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand("INSERT INTO EscalaDePlantao(NomeDoAnalista, DataDoPlantao, Valor,Observacao) values (?,?,?,?) ", Con);
                Cmd.Parameters.AddWithValue("@v1", cadplan.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@v2", cadplan.DataDoPlantao);
                Cmd.Parameters.AddWithValue("@v3", cadplan.Valor);
                Cmd.Parameters.AddWithValue("@v4", cadplan.Observacao);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao Gravar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "";
        }
        public List<CadastroPlantao> ListaDePlantao()
        {
            AbrirConexao();
            Cmd = new OleDbCommand(@"Select * From EscalaDePlantao ", Con);
            Dr = Cmd.ExecuteReader();
            List<CadastroPlantao> Listar = new List<CadastroPlantao>();
            try
            {
                   while (Dr.Read())
                    {
                        CadastroPlantao cadPlan = new CadastroPlantao();
                        cadPlan.Id = Convert.ToInt16(Dr["Id"]);
                        cadPlan.NomeDoAnalista = Dr.GetString(Dr.GetOrdinal("NomeDoAnalista"));
                        cadPlan.DataDoPlantao = Convert.ToDateTime(Dr["DataDoPlantao"]);
                        cadPlan.Valor = Convert.ToDecimal(Dr["Valor"]);
                        cadPlan.Observacao = Dr.GetString(Dr.GetOrdinal("Observacao"));
                        Listar.Add(cadPlan);
                    }
            }
            catch (Exception erro )
            {
                throw new Exception("Erro na lista de plantões " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
    }
}
