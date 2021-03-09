using System;

namespace series
{
    public class Series : EntidadeBase
    {

            // atributos

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao {get; set; }

        private int Ano { get; set; }

        private bool Excluido {get; set;}
    
    
    // metodos

    public Series(int id, Genero genero, string Titulo, string Descricao, int Ano)
    
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Ano = Ano;
        this.Excluido = false;

    }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Título" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano de início" + this.Ano + Environment.NewLine;
                      
            return retorno;
        }
        
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void exclui()
        {
            this.Excluido = true;

        }

        public bool retornaExcluido()
        {
            return this.Excluido;

        }

    
    }
}