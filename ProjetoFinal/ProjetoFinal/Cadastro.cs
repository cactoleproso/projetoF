using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Cadastro
    {
        private Banda Banda { get; set; }
        private ConectarBD con { get; set; }
        public Cadastro(Banda Banda)
        {
            this.Banda = Banda;
            con = new ConectarBD();
        }

        public bool Cadastrar()
        {
            string query = "INSERT INTO bandas(nome, numint, nomemusica, diapref, instru) VALUES(@nome, @numint, @nomemusica, @diapref, @instru);";
            con.AddParameters(Banda, query);
            con.AbrirConexao();

            if(con.Insert())
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
