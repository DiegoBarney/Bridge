using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class PerifericoLeitorCodigoBarras : Hardware
    {
        public int abreComunicacao(string tipoPorta)
        {
            //regra de negocio para interoperabilidade
            return 0;
        }

        public int enviaComando(string commando)
        {
            //regra de negocio para interoperabilidade
            return 0;
        }

        public bool estaOnline()
        {
            //regra de negocio para interoperabilidade
            return true;
        }

        public int fechaComunicacao()
        {
            //regra de negocio para interoperabilidade
            return 0;
        }
    }
}
