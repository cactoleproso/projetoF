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
            cmd.Connection = new MySqlConnection("Server=projeto;Database=test;Uid=root;Pwd=root");
        }
        public bool fazerlogin(string nome , string senha)
        {
            bool result = false;
            try
            {
                cmd.Connection.Open();
                cmd.CommandText = "SELECT * FROM login WHERE nome= @loguser AND senha = @logsenha;";
                cmd.Parameters.AddWithValue("@loguser", nome);
                cmd.Parameters.AddWithValue("@logsenha", senha);
                MySqlDataReader dados = cmd.ExecuteReader();
                result = true;

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

    }
}
