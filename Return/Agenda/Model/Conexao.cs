using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using MetroFramework.Properties;
using MetroFramework;
using System.Windows.Forms;

namespace Agenda.Model
{
    public class Conexao
    {
        public IWin32Window Owner { get; set; }

        public OleDbConnection Con;
        protected OleDbCommand Cmd;
        protected OleDbDataReader Dr;
        protected OleDbDataAdapter Adp;        

        public void AbrirConexao()
        {
            try
            {
                string udl = Path.GetFullPath("Agenda.udl");
                Con = new OleDbConnection("File Name=" + udl);
                Con.Open();
                if (Con.State == ConnectionState.Open)
                {
                    MetroMessageBox.Show(Owner, "Conexao Agenda", "Conectado!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            } 
            catch (Exception)
            {
                MetroMessageBox.Show(Owner, "Erro na conexao", "Não Conectado", MessageBoxButtons.OK, MessageBoxIcon.Hand);   
            }
        }

        public void FechaConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Fecha o banco de dados" + ex.Message);
            }
        }
    }
}
