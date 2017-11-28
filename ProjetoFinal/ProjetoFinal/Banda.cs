using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    class Banda
    {
        public int id { get; private set; }
        public string Nome { get; set; }
        public int NumIntegrantes { get; set; }
        public string NomeMusica { get; set;}
        public int DiaPreferencial { get; set; }
        public int Instrumento { get; set; }
    }
}
