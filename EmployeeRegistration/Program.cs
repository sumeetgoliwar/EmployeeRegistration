using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace EmployeeRegistration
{
    class Program
    {
        static void Main(System.String[] args)
        {
            int n;
            
            Home h1= new Home();
            do
            {
                Console.WriteLine("Welcome to Student Registration");
                Console.WriteLine(" Press 1 to  Insert Data");
                Console.WriteLine(" Press 2 to  Update Data");
                Console.WriteLine(" Press 3 to  Delete Data");
                Console.WriteLine(" Press 4 to  Show All Data");
                Console.WriteLine(" Press 5 to  Exit");

                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        h1.Insert();                        
                        break;
                    case 2:
                        h1.Update();
                        break;
                    case 3:
                        h1.Delete();
                        break;
                    case 4:
                        h1.Show();
                        break;
                    case 5:
                        
                        break;
                    default:
                        Console.WriteLine("Enter Proper number From Menu");
                        break;
                }

            } while (n<5);
        }
    }
}