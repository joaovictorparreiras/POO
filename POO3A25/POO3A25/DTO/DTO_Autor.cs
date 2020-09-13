using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A25.DTO
{
    class DTO_Autor
    {

        private string nome;
        private int idAutor, idade;

        public string Nome {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório.");
                }


            }
            get { return this.nome; }
        }
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
