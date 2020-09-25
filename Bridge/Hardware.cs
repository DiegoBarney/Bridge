using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface Hardware
    {
        int abreComunicacao(String tipoPorta);
        bool estaOnline();
        int enviaComando(String commando);
        int fechaComunicacao();


    }
}
