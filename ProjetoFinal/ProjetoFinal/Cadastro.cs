﻿using System;
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

        const string qr = "INSERT INTO banda(nome, numint, nomemusica, diapref, instru) VALUES(@nome, @numint, @nomemusica, @diapref, @instru);";
        public Cadastro(Banda Banda)
        {
            this.Banda = Banda;
            con = new ConectarBD(qr);
        }

        public bool Cadastrar()
        {
            con.AddParametersCADASTRAR(this.Banda);
            con.AbrirConexao();

            if(con.ExecuteNoN())
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
