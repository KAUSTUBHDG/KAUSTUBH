    using System;
using System.Data.Common;
using System.Threading;

namespace ConsoleApp3
    {
        public abstract class DbConnection
        {
            private string ConnectionString { get; set; }
            private TimeSpan TimeOut { get; set; }

            public DbConnection(string connectionString)
            {
                var timeout = TimeOut;
                ConnectionString = connectionString;
            if (String.IsNullOrEmpty(connection))
                {
                    Console.WriteLine("Cannot pass an empty string!!!");
                }

            }

        public TimeSpan Time(int time)
        {
            time = TimeOut;
            Thread.Sleep(time);
        }

        public abstract void Opening();
        public abstract void Closing();
          
        }

    public class SqlConnection : DbConnection
    {
        private readonly string connectionString;

        public SqlConnection(string connectionString) : base(connectionString)
        {
          
        }


        public override void Closing()
        {
            Console.WriteLine("Closing SQL connection");  
        }

        public override void Opening()
        {
            Console.WriteLine("Opening SQL connection");
        }
    }

    public class  OracleConnection:DbConnection
    {
        public OracleConnection(string connectionString):base(connectionString)
        {

        }
        public override void Closing()
        {
            Console.WriteLine("Closing Oracle connection");
        }

        public override void Opening()
        {
            Console.WriteLine("Opening Oracle connection");
        }
    }    


    class DbCommand
    {
        private DbConnection _dbConnection { get; set; }
        private string _command { get; set; }
        private DbConnection _time { get; set; }

        public DbCommand(DbConnection dbConnection,string command,DbConnection Timeout)
        {
            _dbConnection = dbConnection;
            _command = command;
            _time = Timeout;
        }

 
        public void Execute()
        {
            _dbConnection.Opening();
            _time.Time(100);
            _dbConnection.Closing();
            _time.Time(100);
        }
    }

    class Program
    {
       static void Main(string[] args)
       {
            Console.WriteLine("Tyep SQL or ORACLE to connect to.");
            var input = Console.ReadLine().ToLower();

            if (!string.IsNullOrEmpty(input) && input == "sql")
            {
                var sqlConnection = new SqlConnection(input);
                var dbCommand = new DbCommand(sqlConnection, sqlConnection.ConnectionString);
                dbCommand.Execute();
            }
            else if (!string.IsNullOrEmpty(input) && input == "oracle")
            {
                var oracleConnection = new OracleConnection(input);
                var dbCommand = new DbCommand(oracleConnection, oracleConnection.ConnectionString);
                dbCommand.Execute();
            }
            else
            {
                throw new ArgumentException("Not a valid entry.");
            }
    }
}
