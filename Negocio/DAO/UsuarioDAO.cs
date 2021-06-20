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
    public class UsuarioDAO
    {
        private string StringConexao = "Server=127.0.0.1;Database=DB_web;Uid=root;Pwd=root1234;";
        public void InserirUsuario (Usuario usuario) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Insert<Usuario>(usuario);
            }
        }
        public void AtualizarUsuario (Usuario usuario) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Update<Usuario>(usuario);
            }
        }
        public void ExcluirUsuario (Usuario usuario) 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                connection.Delete<Usuario>(usuario);
            }
        }
        public IList<Usuario> PegarUsuarios() 
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.GetAll<Usuario>().ToList();
            }
        }
        public Usuario PegarUsuarioById(int UsuarioId)
        {
            using (var connection = new MySqlConnection(StringConexao))
            {
                connection.Open();
                return connection.Get<Usuario>(UsuarioId);
            }
        }
    }
}