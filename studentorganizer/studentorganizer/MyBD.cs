using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace studentorganizer
{
    internal class MyDB
    {
        // objeto conexao do banco de dados
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;user=root;password=;database=sga_estudantes_bd;");
    }
}
