using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

// DTO: DATA TRANSFER OBJECTS
namespace blazor_DB
{
    // Adicionando o nome da tabela através do Dapper:
    [Table("TB_CLIENTE")]
    public class Cliente
    {
        // É necessário informar a chave primária da tabela através do Dapper:
        [Key]
        public int CLIID { get; set; }

        public string CLINOME { get; set; }

        public string CLICPF { get; set; }

        public string CLICOMPLEMENTO { get; set; }

        public string CLIBAIRRO { get; set; }

        public string CLIENDERECO { get; set; }

        public string CLICEP { get; set; }
        public string CLICIDADE { get; set; }

        public string CLIUF { get; set; }

        public DateTime CLIDATAHORAENTRADA { get; set; }

        public string CLIEMAIL { get; set; }
        public string CLITELEFONE { get; set; }

        public bool CLIATIVO { get; set; }
    }
}