using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Login
    {
        private Administrador Administrador { get; set; }
        private ConectarBD con { get; set; }
        const string qr = "SELECT * FROM login WHERE nome= @loguser AND senha = @logsenha;";

        public Login(Administrador Administrador)
        {
            this.Administrador = Administrador;
            con = new ConectarBD(qr);
        }

        public bool logar()
        {
            con.AddParametersLOGIN(this.Administrador);
            con.AbrirConexao();
            
            if(con.ExecuteReader())
            {
                con.FecharConexao();
                return true;
            }
            con.FecharConexao();
            return false;
        }
    }
}
