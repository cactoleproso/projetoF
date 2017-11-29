using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Atualiza
    {
        private Banda Banda { get; set; }
        private ConectarBD con { get; set; }
        private string nomeantes { get; set; }

        public Atualiza(Banda Banda, string nomeantes)
        {
            this.Banda = Banda;
            con = new ConectarBD();
            this.nomeantes = nomeantes;
        }

        public bool Atualizar()
        {
            string qr = "UPDATE bandas SET nome = @nome1, numint = @numint, nomemusica = @nomemusica, diapref = @diapref, instru = @instru  WHERE nome = @nome;";

            con.AddParametersUPDATE(this.Banda, qr, this.nomeantes);
            con.AbrirConexao();
            if (con.ExecuteNoN())
            {
                con.FecharConexao();
                return true;
            }
            con.FecharConexao();
            return false;
        }

        public void AtualizaLista()
        {

        }
    }
}
