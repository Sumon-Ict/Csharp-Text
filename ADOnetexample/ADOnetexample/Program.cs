using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ADOnetexample
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=DESKTOP-UBJ9C3M\\SQLEXPRESS2;Database=TestDatabase;User Id = test; Password=sumon1415";

            private static SqlConnection _sqlConnection;

        static void Main(string[] args)
        {
            _sqlConnection = new SqlConnection(CONNECTION_STRING);

            var insertsql="insert into person(Name,Age,Address)values('kajol',45,'dhaka')";
            var deletesql = "delete from person where id=7";


            Write(insertsql);
            Write(deletesql);


            var result = Read("person");
            foreach (var row in result)
            {
                foreach (var col in row)
                {
                    Console.WriteLine($"{col.Key} -> {col.Value}");
                }
                Console.WriteLine(new string('=', 7));
            }




        }
        public static void Write(string sql)
        {
            try
            {
                if(_sqlConnection.State!=System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();

                }
                using var command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();
                return;


            }
            catch(SqlException se)
            {
                Console.WriteLine("ther was a database error " + se.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("something wrong " + ex.Message);
            }
            finally
            {
                if (_sqlConnection?.State != ConnectionState.Closed)
                    _sqlConnection.Close();
            }
        }
        public static IList<IDictionary<string, object>> Read(string tableName)
        {
            var result = new List<IDictionary<string, object>>();
            var query = "Select * from " + tableName;

            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Open();
                }

                using var command = new SqlCommand(query, _sqlConnection);
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));
                    }
                    result.Add(row);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("There was a database error: " + se.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an unknown error: " + ex.Message);
            }
            finally
            {
                _sqlConnection?.Close();
            }

            return result;
        }

    }
}
