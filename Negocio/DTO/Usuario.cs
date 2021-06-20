using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

// DTO: DATA TRANSFER OBJECTS
namespace blazor_DB
{
    // Adicionando o nome da tabela através do Dapper:
    [Table("TB_USUARIO")]
    public class Usuario
    {
        // É necessário informar a chave primária da tabela através do Dapper:
        [Key]
        public int USUID {get; set; }

        public string USULOGIN {get; set; }

        public string USUEMAIL {get; set; }

        public string USUNOMECOMPLETO {get; set; }

        public string USUSENHA {get; set; }

        public DateTime USUDATAHORACRIACAO {get; set; }

        public bool USUATIVO {get; set; }

        public string USUCPF {get; set; }

        public string USUTELEFONE {get; set; }
    }
}