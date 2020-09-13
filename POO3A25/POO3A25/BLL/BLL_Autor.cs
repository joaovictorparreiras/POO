using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using POO3A25.DTO;

namespace POO3A25.BLL
{
    class BLL_Autor
    {
        private DALBD daoBanco = new DALBD();



        public void AlterarAutor(DTO_Autor objautor)
        {
            string sql = string.Format($@"UPDATE tbl_autor set nome = '{objautor.Nome}',
                                                                 idade = '{objautor.Idade}'
                                                   where idAutor = '{objautor.IdAutor}';");
            daoBanco.ExecutarComando(sql);
        }
        // Criação de Metodo para selecionar os dados do cliente - Polimorfismo 
        public DataTable ListarAutor(string condicao)
        {
            string sql = string.Format($@"select * from tbl_autor where" + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable ListarTodosAutor()
        {
            string sql = string.Format($@"select * from tbl_autor");
            return daoBanco.ExecutarConsulta(sql);
        }


        //Metodo para Inserir Cliente no Banco de Dados
        public void InserirAutor(DTO_Autor objautor)
        {
            string sql = string.Format($@"INSERT INTO tbl_autor (idAutor, nome, idade) 
                                                                  VALUES (NULL, '{objautor.Nome}',
                                                                                '{objautor.Idade}');");
            daoBanco.ExecutarComando(sql);
        }

        public void ExcluirAutor(DTO_Autor objautor)
        {
            string sql = string.Format($@"DELETE FROM tbl_autor where idAutor = {objautor.IdAutor};");
            daoBanco.ExecutarComando(sql);
        }

    }
}
