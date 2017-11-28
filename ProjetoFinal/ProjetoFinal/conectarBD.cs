using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
using System.Threading;

namespace ProjetoFinal
{
    class ConectarBD
    {

        private MySqlCommand cmd;

        public ConectarBD()
        {
            cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
        }

        public bool Insert()
        {
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException a)
            {
                return false;
            }
           
        }
        public bool fazerlogin(string nome, string senha)
        {
            bool result = false;
            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "SELECT * FROM login WHERE nome= @loguser AND senha = @logsenha;";
                cmd.Parameters.AddWithValue("@loguser", nome);
                cmd.Parameters.AddWithValue("@logsenha", senha);
                MySqlDataReader dados = cmd.ExecuteReader();
                result = dados.HasRows;


            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return result;
        }
        public void AbrirConexao()
        {
            cmd.Connection.Open();
        }
        public void FecharConexao()
        {
            cmd.Connection.Close();
        }
        public void AddParameters(Banda banda, string qr)
        {
            cmd.CommandText = qr;
            cmd.Parameters.AddWithValue("@nome", banda.Nome);
            cmd.Parameters.AddWithValue("@numint", banda.NumIntegrantes);
            cmd.Parameters.AddWithValue("@nomemusica", banda.NomeMusica);
            cmd.Parameters.AddWithValue("@diapref", banda.DiaPreferencial);
            cmd.Parameters.AddWithValue("@instru", banda.Instrumento);
        }
        public MySqlCommand atualizarlista(string nome)
        {
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = "SELECT * FROM bandas;";
            cmd.Connection.Open();
            return cmd;
        }

        public bool atualizar(Banda banda)
        {
           
            string qr = "UPDATE bandas SET nome = @nome1, numint = @numint, nomemusica = @nomemusica, diapref = @diapref, instru = @instru  WHERE nome = @nome;";

            AddParameters(banda, qr);
            AbrirConexao();
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException a)
            {
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
