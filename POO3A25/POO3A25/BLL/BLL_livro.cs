using System;
using System.Linq;
using System.Data;

namespace POO3A25
{
    class BLL_livro
    {

        private DALBD daoBanco = new DALBD();


        public void AlterarLivro(DTO_livro obj_livro)
        {
            string sql = string.Format($@"UPDATE tbl_livro set numPaginas = '{obj_livro.NumPags}',
                                                                 titulo = '{obj_livro.Titulo}',
                                                                 valor = '{obj_livro.Valor}',
                                                                 idAutor = '{obj_livro.IdAutor}',
                                                                 idEditora = '{obj_livro.IdEditora}'
                                                   where idLivro = '{obj_livro.IdLivro}';");
            daoBanco.ExecutarComando(sql);
        }
        // Criação de Metodo para selecionar os dados do cliente - Polimorfismo 
        public DataTable ListarLivros(string condicao)
        {
            string sql = string.Format($@"select * from tbl_livro where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable ListarTodosLivros()
        {
            string sql = string.Format($@"select * from TBL_Livro");
            return daoBanco.ExecutarConsulta(sql);
        }
       

        //Metodo para Inserir Cliente no Banco de Dados
        public void InserirLivro(DTO_livro ObjLivro)
        {
            string sql = string.Format($@"INSERT INTO TBL_Livro (idLivro, idAutor, idEditora, titulo, numPaginas, valor, dataCadastro) 
                                                                  VALUES (NULL, '{ObjLivro.IdAutor}',
                                                                                '{ObjLivro.IdEditora}',
                                                                                '{ObjLivro.Titulo}',
                                                                                '{ObjLivro.NumPags}',
                                                                                '{ObjLivro.Valor}',
                                                                                '{ObjLivro.DataCadastro}');");
            daoBanco.ExecutarComando(sql);
        }

        public void ExcluirLivro(DTO_livro objLivro)
        {
            string sql = string.Format($@"DELETE FROM tbl_livro where idLivro = {objLivro.IdLivro};");
            daoBanco.ExecutarComando(sql);
        }
    }
}
