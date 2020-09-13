using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using POO3A25.DTO;

namespace POO3A25.BLL
{
    class BLL_Editora
    {

        private DALBD daoBanco = new DALBD();



        public void AlterarEditora(DTO_Editora objeditora)
        {
            string sql = string.Format($@"UPDATE tbl_editora set nome = '{objeditora.Nome}',
                                                                 endereco = '{objeditora.Endereco}',
                                                                 uf = '{objeditora.Uf}'
                                                   where idEditora = '{objeditora.IdEditora}';");
            daoBanco.ExecutarComando(sql);
        }
        // Criação de Metodo para selecionar os dados do cliente - Polimorfismo 
        public DataTable listarEditora(string condicao)
        {
            string sql = string.Format($@"select * from tbl_editora where" + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable ListarTodosEditora()
        {
            string sql = string.Format($@"select * from tbl_editora");
            return daoBanco.ExecutarConsulta(sql);
        }


        //Metodo para Inserir Cliente no Banco de Dados
        public void InserirEditora(DTO_Editora objeditora)
        {
            string sql = string.Format($@"INSERT INTO tbl_editora (idEditora, nome, endereco, uf) 
                                                                  VALUES (NULL, '{objeditora.Nome}',
                                                                                '{objeditora.Endereco}',
                                                                                '{objeditora.Uf}');");
            daoBanco.ExecutarComando(sql);
        }

        public void ExcluirAutor(DTO_Editora objeditora)
        {
            string sql = string.Format($@"DELETE FROM tbl_editora where idAutor = {objeditora.IdEditora};");
            daoBanco.ExecutarComando(sql);
        }

    }
}
