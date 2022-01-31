using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastroSerie
{
    class Serie : EntidadeBase
    {
        //Atributos e suas Propriedades
        private Genero Genero { get; set; }
        private string  Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluindo { get; set; }

        //Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluindo = false;
        }

        //IMPLEMENTAÇAO ToString()
        //Quando converter white line um objeto par string ele executa essa ação
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero " + this.Genero + Environment.NewLine;
            retorno += "Titulo " + this.Titulo + Environment.NewLine;
            retorno += "Descrição " + this.Genero + Environment.NewLine;
            retorno += "Ano" + this.Ano + Environment.NewLine;
            retorno += "Excluido" + this.Excluindo + Environment.NewLine;
            return retorno;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluindo = true;
        }
    }
}




    

