using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Models
{
    class Books
    {


        SqlConnection conn;

        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }

        public ArrayList GetAllBooks()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book b = new Book();
                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                b.Author = reader.GetString(reader.GetOrdinal("Author"));
                b.Edition = reader.GetInt32(reader.GetOrdinal("Edition"));
                books.Add(b);
            }
            conn.Close();
            return books;
        }


        public ArrayList SearchBooks(string x)
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books WHERE Name like '%" + x + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book b = new Book();
                b.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                b.Name = reader.GetString(reader.GetOrdinal("Name"));
                b.Author = reader.GetString(reader.GetOrdinal("Author"));
                b.Edition = reader.GetInt32(reader.GetOrdinal("Edition"));
                books.Add(b);
            }
            conn.Close();
            return books;
        }

    }
}
