using System;
using System.Collections.Generic;
using series.interfaces;

namespace series
{
    public class RepositorioSerie : IRepo<Series>
    {
       
       private List<Series> ListaSerie = new List<Series>();
        
        public void Atualiza(int id, Series objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].exclui(); 
        }

        public void Insere(Series objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Series> lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}