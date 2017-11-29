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
        private MySqlDataReader dados;
        public ConectarBD()
        {
            cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
        }

        public bool ExecuteNoN()
        {
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

           
        }
        public bool ExecuteReader()
        {
            try
            {
                dados = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return dados.HasRows;
            
        }
        public void AbrirConexao()
        {
            cmd.Connection.Open();
        }
        public void FecharConexao()
        {
            cmd.Connection.Close();
        }
        public void AddParametersCADASTRAR(Banda banda, string qr)
        {
            cmd.CommandText = qr;
            cmd.Parameters.AddWithValue("@nome", banda.Nome);
            cmd.Parameters.AddWithValue("@numint", banda.NumIntegrantes);
            cmd.Parameters.AddWithValue("@nomemusica", banda.NomeMusica);
            cmd.Parameters.AddWithValue("@diapref", banda.DiaPreferencial);
            cmd.Parameters.AddWithValue("@instru", banda.Instrumento);
        }
        public void AddParametersUPDATE(Banda banda, string qr, string nomeantes)
        {
            cmd.CommandText = qr;
            cmd.Parameters.AddWithValue("@nome", nomeantes);
            cmd.Parameters.AddWithValue("@nome1", banda.Nome);
            cmd.Parameters.AddWithValue("@numint", banda.NumIntegrantes);
            cmd.Parameters.AddWithValue("@nomemusica", banda.NomeMusica);
            cmd.Parameters.AddWithValue("@diapref", banda.DiaPreferencial);
            cmd.Parameters.AddWithValue("@instru", banda.Instrumento);
        }
        public void AddParametersLOGIN(Administrador Administrador, string qr)
        {
            cmd.CommandText = qr;
            cmd.Parameters.AddWithValue("@loguser", Administrador.Username);
            cmd.Parameters.AddWithValue("@logsenha", Administrador.Password);
        }
        public void AddParametersDELETAR(string nome, string qr)
        {
            cmd.CommandText = qr;
            cmd.Parameters.AddWithValue("@nome", nome);
            
        }
        public MySqlCommand atualizarlista(string nome)
        {
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = "SELECT * FROM bandas;";
            cmd.Connection.Open();
            return cmd;
        }
    }
}
