using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfAntonioHost
{
    public class Anime
    {
        string id_anime;
        public string ID_anime {
            set { id_anime = value; }
            get { return id_anime; }
        }

        string nombre_anime;
        public string Nombre_anime {
            set { nombre_anime = value; }
            get { return nombre_anime; }
        
        }

        int capitulos_anime;
        public int Capitulos_anime {
            set { capitulos_anime = value; }
            get { return capitulos_anime; }
        }

        string temporada_anime; 
        public string Temporada_anime {
            set { temporada_anime = value; }
            get { return temporada_anime; }
        
        
        }
    }
}