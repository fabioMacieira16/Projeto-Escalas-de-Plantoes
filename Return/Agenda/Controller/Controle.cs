using Agenda.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Agenda.Controller
{
    public class Controle : Conexao
    {
        //Grava os Dados
        public string Gravar(Cadastro cad)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"INSERT INTO Agendamento(NomeContato,NomeDaEmpresa,Fone1,Fone2,DataDaLigacao,NomeDoAnalista,StatusDoRetorno,Observacao) 
                                             VALUES (?,?,?,?,?,?,?,?)", Con);
                Cmd.Parameters.AddWithValue("@v1", cad.NomeContato);
                Cmd.Parameters.AddWithValue("@v2", cad.NomeDaEmpresa);
                Cmd.Parameters.AddWithValue("@v3", cad.Fone1);
                Cmd.Parameters.AddWithValue("@v4", cad.Fone2);
                Cmd.Parameters.AddWithValue("@v5", cad.DataDaLigacao).Value = DateTime.Now;
                Cmd.Parameters.AddWithValue("@v6", cad.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@v7", cad.StatusRetorno);
                Cmd.Parameters.AddWithValue("@v8", cad.Observacao);
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //throw new Exception("Erro ao Gravar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "Agendamento ";
        }
        public string Atualizar(Cadastro cad)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@" Update Agendamento 
                                            SET NomeContato = ?,
                                            NomeDaEmpresa = ?,
                                            Fone1 = ?,
                                            Fone2 = ?,
                                            DataDaLigacao = ?,
                                            NomeDoAnalista = ?,        
                                            Observacao = ?
                                            where id = ? ", Con);

                Cmd.Parameters.AddWithValue("@v1", cad.NomeContato);
                Cmd.Parameters.AddWithValue("@v2", cad.NomeDaEmpresa);
                Cmd.Parameters.AddWithValue("@v3", cad.Fone1);
                Cmd.Parameters.AddWithValue("@v4", cad.Fone2);
                Cmd.Parameters.AddWithValue("@v5", cad.DataDaLigacao).Value = DateTime.Now;
                Cmd.Parameters.AddWithValue("@v6", cad.NomeDoAnalista);
                Cmd.Parameters.AddWithValue("@V8", cad.Observacao);
                Cmd.Parameters.AddWithValue("@Id", cad.Id);
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
            return "Agendamento ";
        }
        public string retornar(Cadastro cad)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"UPDATE Agendamento SET StatusDoRetorno = 'true' WHERE Id = ? ", Con);
                Cmd.Parameters.AddWithValue("@v1", cad.Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao Gravar o retorno do Cliente " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return "Agendamento ";
        }
        public void Exluir(int Id)
        {
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"Delete from Agendamento where Id = ? ", Con);
                Cmd.Parameters.AddWithValue("@Id", Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
               // throw new Exception("Erro ao Excluir os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        public List<Cadastro> ListaAgenda()
        {
            AbrirConexao();
            Cmd = new OleDbCommand(@"Select * from Agendamento", Con);
            Dr = Cmd.ExecuteReader();
            List<Cadastro> Listar = new List<Cadastro>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Cadastro cad = new Cadastro();
                        cad.Id = Convert.ToInt16(Dr["Id"]);
                        cad.NomeContato = Dr.GetString(Dr.GetOrdinal("NomeContato"));
                        cad.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                        cad.Fone1 = Dr.GetString(Dr.GetOrdinal("Fone1"));
                        cad.Fone2 = Dr.GetString(Dr.GetOrdinal("Fone2"));
                        cad.DataDaLigacao = Convert.ToDateTime(Dr["DataDaLigacao"]);
                        cad.NomeDoAnalista = Convert.ToString(Dr["NomeDoAnalista"]);
                        cad.StatusRetorno = Convert.ToBoolean(Dr["StatusDoRetorno"]);
                        cad.Observacao = Convert.ToString(Dr["Observacao"]);
                        Listar.Add(cad);
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Listar os Dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        public List<CadastroAnalistas> ListaAnalistas()
        {
            List<CadastroAnalistas> Listar = new List<CadastroAnalistas>();
            try
            {
                AbrirConexao();
                Cmd = new OleDbCommand(@"SELECT * FROM NomeDoAnalista ", Con);

                Dr = Cmd.ExecuteReader();
                while (Dr.Read())
                {
                    CadastroAnalistas cad = new CadastroAnalistas();
                    cad.Id = Convert.ToInt32(Dr["Id"]);
                    cad.NomeDoAnalista = Dr.GetString(Dr.GetOrdinal("NomeDoAnalista"));
                    Listar.Add(cad);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao lista os Analista " + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }

        #region Lista os dados de acorco com o que é marcado no combo
        //Lista todos os cliente retornado
        public List<Cadastro> Ativo()
        {
            AbrirConexao();
            Cmd = new OleDbCommand(@"Select * from Agendamento where StatusDoRetorno > 0", Con);
            Dr = Cmd.ExecuteReader();
            List<Cadastro> Listar = new List<Cadastro>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Cadastro cad = new Cadastro();
                        cad.Id = Convert.ToInt16(Dr["Id"]);
                        cad.NomeContato = Dr.GetString(Dr.GetOrdinal("NomeContato"));
                        cad.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                        cad.Fone1 = Dr.GetString(Dr.GetOrdinal("Fone1"));
                        cad.Fone2 = Dr.GetString(Dr.GetOrdinal("Fone2"));
                        cad.DataDaLigacao = Convert.ToDateTime(Dr["DataDaLigacao"]);
                        cad.NomeDoAnalista = Convert.ToString(Dr["NomeDoAnalista"]);
                        cad.StatusRetorno = Convert.ToBoolean(Dr["StatusDoRetorno"]);
                        cad.Observacao = Convert.ToString(Dr["Observacao"]);
                        Listar.Add(cad);
                    }
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar os dados ativo/inativos" + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        //Lista todos os cliente que não foram retornado
        public List<Cadastro> Inativo()
        {
            AbrirConexao();
            Cmd = new OleDbCommand(@"Select * from Agendamento where StatusDoRetorno = 0 ", Con);
            Dr = Cmd.ExecuteReader();
            List<Cadastro> Listar = new List<Cadastro>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Cadastro cad = new Cadastro();
                        cad.Id = Convert.ToInt16(Dr["Id"]);
                        cad.NomeContato = Dr.GetString(Dr.GetOrdinal("NomeContato"));
                        cad.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                        cad.Fone1 = Dr.GetString(Dr.GetOrdinal("Fone1"));
                        cad.Fone2 = Dr.GetString(Dr.GetOrdinal("Fone2"));
                        cad.DataDaLigacao = Convert.ToDateTime(Dr["DataDaLigacao"]);
                        cad.NomeDoAnalista = Convert.ToString(Dr["NomeDoAnalista"]);
                        cad.StatusRetorno = Convert.ToBoolean(Dr["StatusDoRetorno"]);
                        cad.Observacao = Convert.ToString(Dr["Observacao"]);
                        Listar.Add(cad);
                    }
                }
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao listar os dados ativo/inativos" + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        public List<Cadastro> QtdAtivo()
        {
            AbrirConexao();

            Cmd = new OleDbCommand(@"SELECT COUNT(StatusDoRetorno)from agendamento where StatusDoRetorno = 0 ", Con);
            //Cmd.ExecuteScalar();
            Dr = Cmd.ExecuteReader();
            List<Cadastro> Listar = new List<Cadastro>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Cadastro cad = new Cadastro();
                        //cad.Id = Convert.ToInt16(Dr["Id"]);
                        //cad.NomeContato = Dr.GetString(Dr.GetOrdinal("NomeContato"));
                        //cad.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                        //cad.Fone1 = Dr.GetString(Dr.GetOrdinal("Fone1"));
                        //cad.Fone2 = Dr.GetString(Dr.GetOrdinal("Fone2"));
                        //cad.DataDaLigacao = Convert.ToDateTime(Dr["DataDaLigacao"]);
                        //cad.NomeDoAnalista = Convert.ToString(Dr["NomeDoAnalista"]);
                        //cad.StatusRetorno = Convert.ToBoolean(Dr["StatusDoRetorno"]);
                        cad.StatusRetorno = Dr.GetBoolean(Dr.GetOrdinal("StatusDoRetorno"));
                        //cad.Observacao = Convert.ToString(Dr["Observacao"]);
                        Listar.Add(cad);
                    }
                }
            }
            catch (IndexOutOfRangeException erro)
            {
                throw new Exception("Erro ao listar os dados ativo/inativos" + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        public List<Cadastro> QtdInativo()
        {
            AbrirConexao();

            Cmd = new OleDbCommand(@"Select COUNT(*)from Agendamento where StatusDoRetorno > 0 ", Con);
            Dr = Cmd.ExecuteReader();
            List<Cadastro> Listar = new List<Cadastro>();
            try
            {
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Cadastro cad = new Cadastro();
                        cad.Id = Convert.ToInt16(Dr["Id"]);
                        cad.NomeContato = Dr.GetString(Dr.GetOrdinal("NomeContato"));
                        cad.NomeDaEmpresa = Dr.GetString(Dr.GetOrdinal("NomeDaEmpresa"));
                        cad.Fone1 = Dr.GetString(Dr.GetOrdinal("Fone1"));
                        cad.Fone2 = Dr.GetString(Dr.GetOrdinal("Fone2"));
                        cad.DataDaLigacao = Convert.ToDateTime(Dr["DataDaLigacao"]);
                        cad.NomeDoAnalista = Convert.ToString(Dr["NomeDoAnalista"]);
                        cad.StatusRetorno = Convert.ToBoolean(Dr["StatusDoRetorno"]);
                        cad.Observacao = Convert.ToString(Dr["Observacao"]);
                        Listar.Add(cad);
                    }
                }
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao listar os dados ativo/inativos" + erro);
            }
            finally
            {
                FechaConexao();
            }
            return Listar;
        }
        #endregion

        #region Lista os dados na Grid de acorco com o que é digitado o TextConsultar
        public DataTable RetContato(string retorno)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand(@"Select * from Agendamento where NomeContato like ? ", Con);
                Cmd.Parameters.Add(new OleDbParameter("@v1", retorno));
                OleDbDataAdapter Adp = new OleDbDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao listar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        public DataTable RetEmpresa(string retorno)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand(@"Select * from Agendamento where NomeDaEmpresa like ? ", Con);
                Cmd.Parameters.Add(new OleDbParameter("@v1", retorno));
                OleDbDataAdapter Adp = new OleDbDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao listar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        public DataTable RetNomeAnalista(string retorno)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand(@"Select * From Agendamento where NomeDoAnalista like ? ", Con);
                Cmd.Parameters.Add(new OleDbParameter("@v1", retorno));
                OleDbDataAdapter Adp = new OleDbDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        public DataTable RetDataLigacao(string retorno)
        {
            AbrirConexao();
            try
            {
                Cmd = new OleDbCommand(@"Select * From Agendamento where DataDaLigacao like ? ", Con);
                Cmd.Parameters.Add(new OleDbParameter("@v1", retorno));
                OleDbDataAdapter Adp = new OleDbDataAdapter(Cmd);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                return dt;
            }
            catch (Exception erro)
            {

                throw new Exception("Erro ao listar os dados " + erro);
            }
            finally
            {
                FechaConexao();
            }
        }
        #endregion
    }
}
