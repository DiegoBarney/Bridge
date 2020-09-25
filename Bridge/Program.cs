using System;

namespace Bridge
{ 
    class Program
    {
        static void Main(string[] args)
        {

            //a ideia do bridge é criar um acesso a outro sistema sem expor toda logica para conseguir isso.
            GoogleMaps mapa = new GoogleMaps();
            mapa.devolveMapa("rua abc");



            //Exemplo para comunicacao com periferico
            PerifericoImpressora impressora = new PerifericoImpressora();
            impressora.abreComunicacao("USB");

            if (impressora.estaOnline())
            {
                impressora.enviaComando("CAB00304");
            }

            impressora.fechaComunicacao();
     
        }
    }
}
