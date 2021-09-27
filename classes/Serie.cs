using System;

namespace DIO.Avanade.CRUD.Series{

    public class Serie : EntidadeBase{

        //Atributos
        private Genero genero {get; set;}
        private string titulo {get; set;}
        private string descricao {get; set;}
        private int ano {get; set;}
        private bool excluido {get; set;}

        //Métodos
        public Serie (int id, Genero genero, string titulo, string descricao, int ano){

            this.ID = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.excluido = false;
        }

        public override string ToString(){

            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.ano + Environment.NewLine;
            retorno += "Excluído: " + this.excluido;
            
            return retorno;
        }
        
        public int RetornaID(){

            return this.ID;
        }

        public string RetornaTitulo(){

            return this.titulo;
        }

        public bool RetornaExcluido(){

            return this.excluido;
        }

        public void Excluir(){

            this.excluido = true;
        }
    }
}