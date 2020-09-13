using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A25
{
    class DTO_livro
    {
        private string titulo;
        private int idLivro, idEditora, idAutor, numPags, valor;
        private DateTime dataCadastro;

        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("O campo Titulo é obrigatório.");
                }


            }
            get { return this.titulo; }

        }
        public int NumPags { get => numPags; set => numPags = value; }
        public int Valor { get => valor; set => valor = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
    }
}
