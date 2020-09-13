using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A25.DTO
{
    class DTO_Editora
    {

        private string nome, endereco, uf;
        private int idEditora;

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
        public string Endereco {
            set
            {
                if (value != string.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("O campo endereco é obrigatório.");
                }


            }
            get { return this.nome; }
        }
        public string Uf { get => uf; set => uf = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
    }
}
