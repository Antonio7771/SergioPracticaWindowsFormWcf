using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfAntonioHost
{
    public class MetodosAnime
    {
        public string[] buscar(int id) {
            string[] anime_encontrado = new string[5];
            Anime obj_anime = new Anime();
            if (id==1) {
                obj_anime.ID_anime = "1";
                anime_encontrado[0] = obj_anime.ID_anime;

                obj_anime.Nombre_anime = "shingeki no drogas";
                anime_encontrado[1] =obj_anime.Nombre_anime;

                obj_anime.Capitulos_anime = 12;
                anime_encontrado[2] = obj_anime.Capitulos_anime.ToString();

                obj_anime.Temporada_anime ="temporada 1";
                anime_encontrado[3] = obj_anime.Temporada_anime;
            }
            else
            {
                if (id == 2)
                {
                    obj_anime.ID_anime = "2";
                    anime_encontrado[0] = obj_anime.ID_anime;

                    obj_anime.Nombre_anime = "tacos goul";
                    anime_encontrado[1] = obj_anime.Nombre_anime;

                    obj_anime.Capitulos_anime = 6;
                    anime_encontrado[2] = obj_anime.Capitulos_anime.ToString();

                    obj_anime.Temporada_anime = "temporada 3";
                    anime_encontrado[3] = obj_anime.Temporada_anime;
                }
                else {
                    if (id == 3)
                    {
                        obj_anime.ID_anime = "3";
                        anime_encontrado[0] = obj_anime.ID_anime;

                        obj_anime.Nombre_anime = "la muda";
                        anime_encontrado[1] = obj_anime.Nombre_anime;

                        obj_anime.Capitulos_anime = 12;
                        anime_encontrado[2] = obj_anime.Capitulos_anime.ToString();

                        obj_anime.Temporada_anime = "temporada 2";
                        anime_encontrado[3] = obj_anime.Temporada_anime;

                    }

                }
                
            }
            return anime_encontrado;
        }
    }
}