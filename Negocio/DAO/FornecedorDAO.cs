using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

//DAO: DATA ACCESS OBJECT
namespace blazor_DB
{
    public class FornecedorDAO
    {
        private string StringConexao = "Server=127.0.0.1;Database=DB_web;Uid=root;Pwd=root1234;";
        public void InserirFornecedor (Fornecedor fornecedor) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Insert<Fornecedor>(fornecedor);
            }
        }
        public void AtualizarFornecedor (Fornecedor fornecedor) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Update<Fornecedor>(fornecedor);
            }
        }
        public void ExcluirFornecedor (Fornecedor fornecedor) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Delete<Fornecedor>(fornecedor);
            }
        }
        public IList<Fornecedor> PegarFornecedores() 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.GetAll<Fornecedor>().ToList();
            }
        }
        public Fornecedor PegarFornecedoresById(int FornecedorId)
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.Get<Fornecedor>(FornecedorId);
            }
        }
    }
}