using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Exclui
    {
        private ConectarBD con { get; set; }
        private string nome { get; set; }
        const string qr = "DELETE FROM banda WHERE nome = @nome;";
        public Exclui(string nome)
        {
            con = new ConectarBD(qr);
            this.nome = nome;
        }

        public bool excluir()
        {
            con.AddParametersDELETAR(this.nome);
            con.AbrirConexao();
            if (con.ExecuteNoN())
            {
                con.FecharConexao();
                return true;
            }
            else
            {
                con.FecharConexao();
                return false;
            }
        }



    }
}
