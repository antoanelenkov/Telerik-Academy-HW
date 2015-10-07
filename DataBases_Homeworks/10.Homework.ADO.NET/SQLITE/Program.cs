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
            string connectionStringForMySql = ConfigurationManager.ConnectionStrings["BooksMySql"].ConnectionString;

            /*Download and install MySQL database, MySQL Connector/ Net(.NET Data Provider for MySQL) +MySQL Workbench 
            GUI administration tool.
            Create a MySQL database to store Books(title, author, publish date and ISBN).
            Write methods for listing all books, finding a book by name and adding a book.
            10. Re-implement the previous task with SQLite embedded DB (see http://sqlite.phxsoftware.com).*/

        }
    }
}
