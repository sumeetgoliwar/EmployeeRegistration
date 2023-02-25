using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace EmployeeRegistration
{
    class Home
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public decimal phone { get; set; }
        public int NpgsqlDataReader { get; private set; }

        public void Insert()
        {
            try
            {
                String cs = "server=localhost;port=5432;User Id=postgres;Password=Aryanx@100;Database=Employees";
                NpgsqlConnection con = new NpgsqlConnection(cs);
                Console.WriteLine("Enter Id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                lastname = Console.ReadLine();
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone No.");
                phone = Convert.ToDecimal(Console.ReadLine());
                String query = "insert into public.Employee(id,firstname,lastname,age,phone) values(@id,@firstname,@lastname,@age,@phone)";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@phone", phone);
                con.Open();
                int n1 = cmd.ExecuteNonQuery();
                if (n1 > 0)
                {
                    Console.WriteLine("Query Executed");
                }
                con.Close();
            }
            catch(Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
            
        }

        public void Delete()
        {
            try
            {
                String cs = "server=localhost;port=5432;User Id=postgres;Password=Aryanx@100;Database=Employees";
                NpgsqlConnection con = new NpgsqlConnection(cs);
                Console.WriteLine("Enter Id");
                id = Convert.ToInt32(Console.ReadLine());
                
                String query = "delete from Employee where id=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                
                con.Open();
                int n1 = cmd.ExecuteNonQuery();
                if (n1 > 0)
                {
                    Console.WriteLine("Query Executed");
                }
                con.Close();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Update()
        {
            try
            {
                String cs = "server=localhost;port=5432;User Id=postgres;Password=Aryanx@100;Database=Employees";
                NpgsqlConnection con = new NpgsqlConnection(cs);
                Console.WriteLine("Enter Id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter First Name");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                lastname = Console.ReadLine();
                Console.WriteLine("Enter Age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone No.");
                phone = Convert.ToDecimal(Console.ReadLine());
                String query = "update public.Employee set firstname=@firstname,lastname=@lastname,age=@age,phone=@phone where id=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@phone", phone);
                con.Open();
                int n1 = cmd.ExecuteNonQuery();
                if (n1 > 0)
                {
                    Console.WriteLine("Query Executed, Data Inserted in Database");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Show()
        {
            try
            {
                String cs = "server=localhost;port=5432;User Id=postgres;Password=Aryanx@100;Database=Employees";
                NpgsqlConnection con = new NpgsqlConnection(cs);
                String query = "select * from public.Employee";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                NpgsqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(" id = " + sdr["id"] + "  FirstName = " + sdr["firstname"]+ "  LastName = " + sdr["lastname"]+ "  Age = " + sdr["age"]+ "  Phone No. = " + sdr["phone"]+"\n");
                   
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
