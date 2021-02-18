using System;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;


namespace SushiShop.Misc.DescribingClass
{
    class DBTableConstructorFile
    {
        private static string GCD => Directory.GetCurrentDirectory();
        private static string P => GCD?.Substring(0, GCD?.LastIndexOf("bin") ?? 0);
        private static string FileName => "SushiShop.mdf";
        private static string DB => P + FileName;

        private static string S => $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={DB};Integrated Security=True;Connect Timeout=30";
        private static SqlConnection GetConnection() => new SqlConnection(S);

        private string RestaurantName = "SushiShop";

        public DBTableConstructorFile()
        {
            var connection = GetConnection();
            var command = new SqlCommand("", connection);

            
            try
            {
                connection.Open();

                var firstName = "first_name";
                var lastName = "last_name";

                for (var t = 0; t < 10; t++)
                {
                    var createTable = $"CREATE TABLE hei{t} ( {firstName} varchar(20), {lastName} varchar(20) )";

                    command.CommandText = createTable;
                    command.ExecuteNonQuery();
                    //DropTable(command, t);
                }







            }
            catch(Exception e)
            {
                ErrorDoc.AppendError("Error occured during construction of DB tables \n" + e);
            }
        }


        private string InsertValues(string where, string column, string values) => Insert(where, column) + Values(values);

        private string Insert(string where, string column) => $"INSERT INTO {where} ({column}) ";
        private string Values(string values) => $"VALUES ({values})";

        private void DropTable(SqlCommand command, int index, params string[] freeEntry)
        {
            //var action = freeEntry.Contains("WHERE")
            //    ? freeEntry.ToList().Find(x => x == freeEntry.) 
            //    : freeEntry.ToList().Find(x => x == $"WHERE");

            command.CommandText = @$"DROP TABLE hei{index}";
            command.ExecuteNonQuery();
        }        
        
        private void TruncateTable(SqlCommand command, int index, string freeEntry)
        {
            command.CommandText = @$"TRUNCATE TABLE hei{index}";
            command.ExecuteNonQuery();
        }        
        
        
        private void FreeHandCommandText(SqlCommand command, int index, string freeEntry)
        {
            command.CommandText = @$"    {freeEntry}     "; command.ExecuteNonQuery();
        }

        //private void IngredientsBuider(string where, string columns, string content, int endI, int endJ, int startI = 0, int startJ = 0)
        //{
        //    var connection = GetConnection();
        //    var command = new SqlCommand("", connection);


        //    // Fill Tables 2d
        //    for (var i = startI; i < endI; i++) // Ingredients Width Storage (Uniqe Ingredient) 
        //    for (var j = startJ; j < endJ; j++) // Ingredient Storage Initial Value
        //    {
        //        //= new[] { $"{firstName}", $"{lastName}" };
        //            //= new[] { $"{j}", "\'tang\'" };
        //        if(command) { }
                    
        //        command.CommandText = InsertValues("Ingredients", columns, content);
        //        command.ExecuteNonQuery();
        //    }
        //}
    }
}

