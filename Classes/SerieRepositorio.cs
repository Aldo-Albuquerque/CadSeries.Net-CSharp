using System;
using System.Collections.Generic;
using CadSeries.Interfaces;

namespace CadSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int Id, Serie objeto)
        {
            listaSerie[Id] = objeto;
        }

        public void Exclui(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}