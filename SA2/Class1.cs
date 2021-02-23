using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2
{
    class UsuarioListado

    {
        public int Identificador;
        public string Nome;
        public int idade;


        public UsuarioListado(int IdN, string NomeUs, int IdadeN)
        {
            Identificador = IdN;
            Nome = NomeUs;
            idade = IdadeN;

        }


    }
}
