using System;
using System.Collections.Generic;
using Movies.Interfaces;

namespace Movies
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        public List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }
        public List<Series> Lista()
        {
            return  listaSerie;
        }
        public int ProximoId()
        {
            return listaSerie.Count;
        }
        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }        
    }
}