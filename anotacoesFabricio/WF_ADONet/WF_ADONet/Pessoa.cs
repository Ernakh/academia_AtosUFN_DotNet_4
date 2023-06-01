using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public string profissao;


        public bool gravarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into pessoas " +
                " values (@nome, @profissao);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
