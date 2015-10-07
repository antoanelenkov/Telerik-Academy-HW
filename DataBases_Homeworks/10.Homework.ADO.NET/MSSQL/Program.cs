namespace MSSQL
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Drawing;
    using System.Data.SqlClient;
    using System.Data.OleDb;

    class Program
    {
        private const int OLE_METAFILEPICT_START_POSITION = 78;

        static void Main()
        {
            // Note: if you are using SQL Express version, change the connection string in "dbCon".
            string connectionStringForExpress = ConfigurationManager.ConnectionStrings["NorthWindForExpress"].ConnectionString;
            string connectionStringForSql = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string connectionStringForExcel = ConfigurationManager.ConnectionStrings["ExamsExcel"].ConnectionString;

            // 1.Write a program that retrieves from the Northwind sample database in MS SQL Server 
            // the number of rows in the Categories table.
            GetNumberOfCategories(connectionStringForSql);

            // 2.Write a program that retrieves the name and description of all categories in the Northwind DB.
            GetCategoriesWithDescritions(connectionStringForSql);

            /* 3.Write a program that retrieves from the Northwind database all product categories and the names of the products 
            in each category. Can you do this with a single SQL query (with table join)? */
            GetCategoriesWithProducts(connectionStringForSql);

            /* 4.Write a method that adds a new product in the products table in the Northwind database.
            Use a parameterized SQL command.*/
            AddProduct(connectionStringForSql);

            // 5.Write a program that retrieves the images for all categories in the Northwind database 
            // and stores them as JPG files in the file system.
            ExtractImagesFromDBAndSaveToFile(connectionStringForSql);

            /* 6.Create an Excel file with 2 columns: name and score:
            Write a program that reads your MS Excel file through the OLE DB data provider and displays 
            the name and score row by row. */
            GetDataFromExcel(connectionStringForExcel);

            // 7.Implement appending new rows to the Excel file.
            AddDataToExcel(connectionStringForExcel);

            //Write a program that reads a string from the console and finds all products that contain this string.
            //Ensure you handle correctly characters like ', %, ", \ and _.
            Console.WriteLine("Search for product:");
            var input = Console.ReadLine();

            SearchProductByPattern(input,connectionStringForSql);
        }

        private static void SearchProductByPattern(string input, string connectionStringForSql)
        {
            input = EscapeSymbols(input);

            var dbCon = new SqlConnection(connectionStringForSql);
            dbCon.Open();

            using (dbCon)
            {
                var command = new SqlCommand(@"SELECT ProductName FROM Products
                                             WHERE ProductName LIKE '%'+@input+'%'", dbCon);
                command.Parameters.AddWithValue("@input", input);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["ProductName"]);
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

        private static void AddDataToExcel(string connectionStringForExcel)
        {
            OleDbConnection dbCon = new OleDbConnection(connectionStringForExcel);
            dbCon.Open();

            var counter = 5;
            using (dbCon)
            {
                OleDbCommand command = new OleDbCommand(@"INSERT INTO [Exams$]
                                                    VALUES
                                                   (@name,@score)", dbCon);

                // I do not have any idea why in the excel file, this counter does not work. If you figure out, let me know. Thanks :))
                for (int i = 0; i < 5; i++)
                {
                    command.Parameters.AddWithValue("@name", "User" + counter);
                    command.Parameters.AddWithValue("@score", counter);
                    command.ExecuteNonQuery();

                    counter++;
                }
            }
        }

        private static void GetDataFromExcel(string connectionStringForExcel)
        {
            OleDbConnection dbCon = new OleDbConnection(connectionStringForExcel);
            dbCon.Open();
            using (dbCon)
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Exams$]", dbCon);
                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    var name = reader["Name"];
                    var score = reader["Score"];

                    Console.WriteLine("Name: {0}, Score: {1}", name, score);
                }
            }
        }

        private static void ExtractImagesFromDBAndSaveToFile(string connectionString)
        {
            byte[] image = null;
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmd = new SqlCommand("SELECT Picture FROM Categories", dbCon);
                SqlDataReader reader = cmd.ExecuteReader();

                var count = 0;
                string filePath;
                while (reader.Read())
                {
                    filePath = String.Format(@"..\..\pictures\CategoryPicture{0}.jpg", count);
                    image = (byte[])reader["Picture"];
                    WiriteImageFile(filePath, image);
                    count++;
                }
            }
        }

        private static void WiriteImageFile(string fileName, byte[] fileContents)
        {
            using (var ms = new MemoryStream(fileContents, OLE_METAFILEPICT_START_POSITION, fileContents.Length - OLE_METAFILEPICT_START_POSITION))
            {
                Image img = Image.FromStream(ms);


                img.Save(fileName);
            }
        }

        private static void AddProduct(string connectionString)
        {
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    @"INSERT INTO Products 
                    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                    VALUES
                    (@name,@supplierId,@categoryId,@quantityPerUnit,@unitPrice,@unitInStock,@unitsOnOrder,@recordLevel,@discontinued)", dbCon);

                command.Parameters.AddWithValue("@name", "From C#");
                command.Parameters.AddWithValue("@supplierId", 1);
                command.Parameters.AddWithValue("@categoryId", 1);
                command.Parameters.AddWithValue("@quantityPerUnit", "2 bags");
                command.Parameters.AddWithValue("@unitPrice", 234.5);
                command.Parameters.AddWithValue("@unitInStock", 1000);
                command.Parameters.AddWithValue("@unitsOnOrder", 50);
                command.Parameters.AddWithValue("@recordLevel", 12);
                command.Parameters.AddWithValue("@discontinued", 0);

                command.ExecuteNonQuery();
                Console.WriteLine("The record has been added!");
            }
            Console.WriteLine();
        }

        private static void GetNumberOfCategories(string connectionString)
        {
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbCon);
                int rows = (int)command.ExecuteScalar();
                Console.WriteLine("All rows in table [Categories] are: {0}", rows);
            }
            Console.WriteLine();
        }

        private static void GetCategoriesWithDescritions(string connectionString)
        {
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var name = (string)reader["CategoryName"];
                    var description = (string)reader["Description"];
                    Console.WriteLine("Category name: {0}, Category Description: {1}", name, description);
                }
            }
            Console.WriteLine();
        }

        private static void GetCategoriesWithProducts(string connectionString)
        {
            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(@"SELECT c.CategoryName, p.ProductName
                                                        FROM Categories c, Products p
                                                        WHERE c.CategoryID=p.CategoryID
                                                        ORDER BY c.CategoryName", dbCon);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var name = (string)reader["CategoryName"];
                    var description = (string)reader["ProductName"];
                    Console.WriteLine("Category name: {0}, Product Name: {1}", name, description);
                }
            }
            Console.WriteLine();
        }
    }
}
