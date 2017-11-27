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

        public bool cadastrar(string nome, int numero, string nomemusica, int dia, int instru)
        {
            bool funcionou = false;
            cmd.Connection.Open();
            cmd.CommandText = "INSERT INTO bandas (nome, numint, nomemusica, diapref, instru) VALUES (@nome, @numint, @nomemusica, @diapref, @instru);";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@numint", numero);
            cmd.Parameters.AddWithValue("@nomemusica", nome);
            cmd.Parameters.AddWithValue("@diapref", dia);
            cmd.Parameters.AddWithValue("@instru", instru);
            try
            {
                cmd.ExecuteNonQuery();
                return funcionou = true;
            }
            catch (MySqlException a)
            {
                throw new Exception(a.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public MySqlCommand atualizarlista(string nome)
        {
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = "SELECT * FROM bandas;";
            cmd.Connection.Open();
            return cmd;
        }

        public bool atualizar(string nome, string nomeed, int numero, string nomemusica, int dia, int instru)
        {
            bool funcionou = false;
            cmd.Connection.Open();
            cmd.CommandText = "UPDATE bandas SET nome = @nome1  WHERE nome = @nome"//"INSERT INTO bandas (nome, numint, nomemusica, diapref, instru) VALUES (@nome, @numint, @nomemusica, @diapref, @instru);";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@numint", numero);
            cmd.Parameters.AddWithValue("@nomemusica", nome);
            cmd.Parameters.AddWithValue("@diapref", dia);
            cmd.Parameters.AddWithValue("@instru", instru);
            try
            {
                cmd.ExecuteNonQuery();
                return funcionou = true;
            }
            catch (MySqlException a)
            {
                throw new Exception(a.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
