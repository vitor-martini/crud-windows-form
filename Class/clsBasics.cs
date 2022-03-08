using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASICS.Class
{
    public class clsBasics
    {
        //Instancia a classe de conexão
        clsConexao oClsConexao = new clsConexao();  
        //Cria mensagem pública
        public string sMensagem = "";

        //Método de inserir
        public void Insert(string valor)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_insert");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@valor", SqlDbType.VarChar).Value = valor;

                //Connect com banco
                oSqlCmd.Connection = oClsConexao.Connect();
                //Executar Comando
                oSqlCmd.ExecuteNonQuery();
                //Disconnect
                oClsConexao.Disconnect();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro: " + erro;
            }
        }

        //Método LoadGrid
        public void LoadGrid(DataGridView grdTeste, string valor)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_grid");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@valor", SqlDbType.VarChar).Value = valor;

                //Connect com banco
                oSqlCmd.Connection = oClsConexao.Connect();
                //Executar Comando
                DataTable oDataTable = new DataTable();
                oDataTable.Load(oSqlCmd.ExecuteReader());
                grdTeste.DataSource = oDataTable;
                //Disconnect
                oClsConexao.Disconnect();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro: " + erro;
            }
        }

        //Método LoadField
        public void LoadField(string coluna, string parametro, TextBox txtRetorno)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_dados");
                SqlDataReader oSqlDataReader;
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Parametros
                oSqlCmd.Parameters.AddWithValue("@coluna", SqlDbType.VarChar).Value = coluna;
                oSqlCmd.Parameters.AddWithValue("@parametro", SqlDbType.VarChar).Value = parametro;


                //Connect com banco
                oSqlCmd.Connection = oClsConexao.Connect();
                //Executar Comando
                oSqlDataReader = oSqlCmd.ExecuteReader();
                while (oSqlDataReader.Read())
                {
                    txtRetorno.Text = oSqlDataReader.GetValue(oSqlDataReader.GetOrdinal("Dado")).ToString();

                }


                //Disconnect
                oClsConexao.Disconnect();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro: " + erro;
            }
        }

        //Método LoadCombo
        public void LoadCombo(ComboBox oCombo)
        {
            try
            {

                //Comando SQL 
                SqlCommand oSqlCmd = new SqlCommand("sp_select_combo");
                oSqlCmd.CommandType = CommandType.StoredProcedure;

                //Connect com banco
                oSqlCmd.Connection = oClsConexao.Connect();
                //Executar Comando
                DataTable oDataTable = new DataTable();
                oDataTable.Load(oSqlCmd.ExecuteReader());
                oCombo.ValueMember = "codigo";
                oCombo.DisplayMember = "valor";
                oCombo.DataSource = oDataTable;
                //Disconnect
                oClsConexao.Disconnect();
                //Monstrar mensagens de retorno
                this.sMensagem = "Cadastrado com sucesso!";

            }
            catch (SqlException erro)
            {
                this.sMensagem = "Erro: " + erro;
            }
        }
    }
}
