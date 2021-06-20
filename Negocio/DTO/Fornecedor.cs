using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

// DTO: DATA TRANSFER OBJECTS
namespace blazor_DB
{
    // Adicionando o nome da tabela através do Dapper:
    [Table("TB_FORNECEDOR")]
    public class Fornecedor
    {
        // É necessário informar a chave primária da tabela através do Dapper:
        [Key]
        public int FORID { get; set; }

        public string FORNOMERAZAOSOCIAL { get; set; }

        public string FORCPFCNPJ { get; set; }

        public string FORENDERECO { get; set; }

        public string FORCOMPLEMENTO { get; set; }

        public string FORBAIRRO { get; set; }

        public string FORUF { get; set; }
        
        public string FORCIDADE { get; set; }

        public string FORCEP { get; set; }

        public string FORINSCRICAOESTADUAL { get; set; }

        public string FORTELEFONE { get; set; }

        public string FOREMAIL { get; set; }

        public bool FORATIVO { get; set; }
    }
}