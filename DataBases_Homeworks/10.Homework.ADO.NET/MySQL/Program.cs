namespace MySQL
{
    using System;
    using System.Configuration;
    using MySql.Data.MySqlClient;

    class Program
    {
        static void Main()
        {
            string connectionStringForMySql = ConfigurationManager.ConnectionStrings["BooksMySql"].ConnectionString;

            /*Download and install MySQL database, MySQL Connector/ Net(.NET Data Provider for MySQL) +MySQL Workbench 
           GUI administration tool.
           Create a MySQL database to store Books(title, author, publish date and ISBN).
           Write methods for listing all books, finding a book by name and adding a book.*/

            //NOTE - CHANGE YOUR PASSWORD FOR MYSQL IN 'App.config'
            GetBooksFromMySql(connectionStringForMySql);

            InsertBooks(connectionStringForMySql);

            Console.WriteLine("Write pattern for searching book by title:");
            var pattern = Console.ReadLine();
            SearchBookByPattern(pattern, connectionStringForMySql);
        }

        private static void SearchBookByPattern(string input, string connectionStringForMySql)
        {
            input = EscapeSymbols(input);

            var dbCon = new MySqlConnection(connectionStringForMySql);
            dbCon.Open();

            using (dbCon)
            {
                var command = new MySqlCommand(String.Format("SELECT Title FROM books WHERE Title LIKE '%{0}%'", input), dbCon);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Title"]);
                }
            }
        }

        private static void InsertBooks(string connectionStringForMySql)
        {
            MySqlConnection dbCon = new MySqlConnection(connectionStringForMySql);
            dbCon.Open();

            var command = new MySqlCommand("INSERT INTO books(Title,Author, PublishDate, ISBN) VALUES (@title,@author,@publishDate,@isbn)", dbCon);
            command.Parameters.AddWithValue("@title", "New Book");
            command.Parameters.AddWithValue("@author", "New Author");
            command.Parameters.AddWithValue("@publishDate", DateTime.Now);
            command.Parameters.AddWithValue("@isbn", "2324-324-34");

            command.ExecuteNonQuery();
        }

        private static void GetBooksFromMySql(string connectionStringForMySql)
        {
            MySqlConnection dbCon = new MySqlConnection(connectionStringForMySql);
            dbCon.Open();

            using (dbCon)
            {
                var command = new MySqlCommand(@"SELECT Title, Author, ISBN, PublishDate FROM books", dbCon);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Title: {0}, Author: {1}, ISBN: {2}, PublishDate: {3}",
                        reader["Title"], reader["Author"], reader["ISBN"], (DateTime)reader["PublishDate"]);
                }
            }
        }

        private static string EscapeSymbols(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }
            }

            return input;
        }
    }
}
