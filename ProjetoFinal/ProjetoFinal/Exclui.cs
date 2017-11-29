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
        const string qr = "DELETE FROM bandas WHERE nome = @nome;";
        public Exclui(string nome)
        {
            con = new ConectarBD();
            this.nome = nome;
        }

        public bool excluir()
        {
            con.AddParametersDELETAR(this.nome, qr);
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
