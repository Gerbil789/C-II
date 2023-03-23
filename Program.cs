using Microsoft.Data.Sqlite;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
    }


    public class Order
    {
        [Key]
        public long Id { get; set; }
        public long CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
    }
    //Add-Migration FirstMigration
    public class MyDatabase : DbContext
    {
        public DbSet<Customer> customer { get; set; }
        public DbSet<Order> order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydb.db");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            string sql = File.ReadAllText("database-create.sql");
            string connectionString = "Data Source=mydb.db;";
            
            
            using (SqliteConnection conn = new SqliteConnection(connectionString))
            {
                Customer cust = conn.QueryFirst<Customer>("SELECT * FROM [Customer] WHERE Id = 1");
                cust.Address = "Meh";
                conn.Update(cust);

                
                conn.Execute(@"INSERT INTO [Customer] ([Name], [Address]) VALUES (@Name, @Address)",
                    new
                    {
                        Name = "Vojta",
                        Address = "Lhota"
                    });
                

                long count = conn.QueryFirst<long>("SELECT COUNT(*) FROM [Customer]");
                Console.WriteLine(count);

                foreach(Customer c in conn.Query<Customer>("Select * FROM [Customer]"))
                {
                    Console.WriteLine($"{c.Id} | {c.Name} | {c.Address}");
                }*/

            //conn.Open();

            //using SqliteTransaction tran = conn.BeginTransaction();

            /*
            using SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            */
            /*
            string name = "test_user";
            string address = null;


            string insertSql = @"INSERT INTO [Customer] ([Name], [Address]) VALUES (@Name, @Address)";

            using SqliteCommand insert = new SqliteCommand(insertSql, conn);

            insert.Parameters.AddWithValue("@Name", name);
            //insert.Parameters.AddWithValue("@Address", address == null ? DBNull.Value : address);


            insert.Parameters.Add(new SqliteParameter()
            {
                ParameterName = "@Address",
                Value = address == null ? DBNull.Value : address,
                DbType = System.Data.DbType.AnsiString
            });

            insert.ExecuteNonQuery();


            using SqliteCommand cmd = new SqliteCommand(
                "SELECT COUNT(*) FROM [Customer]",
                conn
                );
            long count = (long)cmd.ExecuteScalar();
            Console.WriteLine($"Count: {count}");

            using SqliteCommand cmd2 = new SqliteCommand(
                "SELECT * FROM [Customer]",
                conn
                );
            using SqliteDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(reader.GetOrdinal("Id")); //get index 
                string name = reader.GetString(1);
                string address = reader.IsDBNull(2) ? null : reader.GetString(2); //read null

                Console.WriteLine($"{id} | {name} | {address}");
            }
            


            //DAPPER





        }
            */
        }
    }
}