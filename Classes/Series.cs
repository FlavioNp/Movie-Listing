using System;

namespace Movies
{
    public class Series : EntidadeBase 
    {
        // Atributos
        public Series(Genero genero, string titulo, string descricao, int ano) 
        {
            this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
               
        }
                private Genero Genero { get; set; }

        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluído {get; set;}

        // Métodos
        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluído = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
         {
             return this.Id;
         }
         public void Excluir() {
             this.Excluído = true;
         }
    }
}