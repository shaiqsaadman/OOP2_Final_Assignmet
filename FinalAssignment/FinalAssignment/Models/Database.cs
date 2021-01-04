using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Models
{
    class Database
    {

        public Books Books { get; set; }
        public Database()
        {
            string connString = @"Server=DESKTOP-9GTJ8MC\SQLEXPRESS; Database=FinalAssgnment; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Books = new Books(conn);
        }

    }
}
