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
        public MySqlDataReader rd { get; private set; }
        public ConectarBD(string qr)
        {
            cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.CommandText = qr;
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
                rd = cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return rd.HasRows;
            
        }
        public void AbrirConexao()
        {
            cmd.Connection.Open();
        }
        public void FecharConexao()
        {
            cmd.Connection.Close();
        }
        public void AddParametersCADASTRAR(Banda banda)
        {
            cmd.Parameters.AddWithValue("@nome", banda.Nome);
            cmd.Parameters.AddWithValue("@numint", banda.NumIntegrantes);
            cmd.Parameters.AddWithValue("@nomemusica", banda.NomeMusica);
            cmd.Parameters.AddWithValue("@diapref", banda.DiaPreferencial);
            cmd.Parameters.AddWithValue("@instru", banda.Instrumento);
        }
        public void AddParametersUPDATE(Banda banda, string nomeantes)
        {

            cmd.Parameters.AddWithValue("@nome", nomeantes);
            cmd.Parameters.AddWithValue("@nome1", banda.Nome);
            cmd.Parameters.AddWithValue("@numint", banda.NumIntegrantes);
            cmd.Parameters.AddWithValue("@nomemusica", banda.NomeMusica);
            cmd.Parameters.AddWithValue("@diapref", banda.DiaPreferencial);
            cmd.Parameters.AddWithValue("@instru", banda.Instrumento);
        }
        public void AddParametersLOGIN(Administrador Administrador)
        {
            
            cmd.Parameters.AddWithValue("@loguser", Administrador.Username);
            cmd.Parameters.AddWithValue("@logsenha", Administrador.Password);
        }
        public void AddParametersDELETAR(string nome)
        {
            cmd.Parameters.AddWithValue("@nome", nome);         
        }
        public MySqlCommand atualizarlista(string nome)
        {
            cmd.Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=root");
            cmd.Connection.Open();
            return cmd;
        }
    }
}
