using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleConnectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"];

            var factory = DbProviderFactories.GetFactory(connectionString.ProviderName);

            Console.WriteLine("{0} Provider Factory successfully resolved", connectionString.ProviderName);

            var connection = factory.CreateConnection();

            connection.ConnectionString = connectionString.ConnectionString;

            connection.Open();

            Console.WriteLine("Connection successfully opened to {0}", connectionString.ConnectionString);

            Console.ReadLine();
        }
    }
}
