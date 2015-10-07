namespace SQLITE
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Data.SQLite;

    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=..\..\db\SQLiteBooks; Version=3";
            /*Download and install MySQL database, MySQL Connector/ Net(.NET Data Provider for MySQL) +MySQL Workbench 
            GUI administration tool.
            Create a MySQL database to store Books(title, author, publish date and ISBN).
            Write methods for listing all books, finding a book by name and adding a book.
            10. Re-implement the previous task with SQLite embedded DB (see http://sqlite.phxsoftware.com).*/
            GetBooks(connectionString);
            InsertBook(connectionString);
        }

        private static void InsertBook(string connectionString)
        {
            SQLiteConnection dbCon = new SQLiteConnection(connectionString);
            dbCon.Open();

            var command = new SQLiteCommand("INSERT INTO books(Title,Author, PublishDate, ISBN) VALUES (@title,@author,@publishDate,@isbn)", dbCon);
            command.Parameters.AddWithValue("@title", "New Book");
            command.Parameters.AddWithValue("@author", "New Author");
            command.Parameters.AddWithValue("@publishDate", DateTime.Now);
            command.Parameters.AddWithValue("@isbn", "2324-324-34");

            command.ExecuteNonQuery();
        }

        private static void GetBooks(string connectionString)
        {
            SQLiteConnection dbCon = new SQLiteConnection(connectionString);
            dbCon.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Books", dbCon);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Title: {0}, Author: {1} ISBN: {2}, published on: {3}",
                       reader["Title"], reader["Author"], reader["ISBN"], ((DateTime)reader["PublishDate"]));
            }
        }
    }
}
