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
        private string nomeAntes { get; set; }
        const string qr = "UPDATE banda SET nome = @nome1, numint = @numint, nomemusica = @nomemusica, diapref = @diapref, instru = @instru  WHERE nome = @nome;";
        public Atualiza(Banda Banda, string nomeantes)
        {
            this.Banda = Banda;
            con = new ConectarBD(qr);
            this.nomeAntes = nomeantes;
        }

        public bool Atualizar()
        {

            con.AddParametersUPDATE(this.Banda, this.nomeAntes);
            con.AbrirConexao();
            if (con.ExecuteNoN())
            {
                con.FecharConexao();
                return true;
            }
            con.FecharConexao();
            return false;
        }
       
    }
}
