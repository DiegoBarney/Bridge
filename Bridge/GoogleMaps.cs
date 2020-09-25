using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bridge
{
    class GoogleMaps : Mapa
    {
        public string devolveMapa(string rua)
        {

            //regra de negocio para pegar mapa do google
            return "mapa";
        }
    }
}
