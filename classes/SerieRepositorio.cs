using System;
using System.Collections.Generic;
using DIO.Avanade.CRUD.Series.interfaces;

namespace DIO.Avanade.CRUD.Series{

    public class SerieRepositorio : IRepositorio<Serie>{

        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie objeto){

            listaSerie[id] = objeto;
        }

        public void Exclui(int id){

            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto){

            listaSerie.Add(objeto);
        }

        public List<Serie> lista(){

            return listaSerie;
        }

        public int ProximoID(){

            return listaSerie.Count;
        }

        public Serie RetornaPorID(int id){

            return listaSerie[id];
        }
    }
}