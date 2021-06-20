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
    public class ClienteDAO
    {
        private string StringConexao = "Server=127.0.0.1;Database=DB_web;Uid=root;Pwd=root1234;";
        public void InserirCliente (Cliente cliente) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Insert<Cliente>(cliente);
            }
        }
        public void AtualizarCliente (Cliente cliente) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Update<Cliente>(cliente);
            }
        }
        public void ExcluirCliente (Cliente cliente) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Delete<Cliente>(cliente);
            }
        }
        public IList<Cliente> PegarClientes() 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.GetAll<Cliente>().ToList();
            }
        }
        public Usuario PegarClientesById(int ClienteId)
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.Get<Usuario>(ClienteId);
            }
        }
    }
}