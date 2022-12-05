using ConsoleApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client =new ServiceReference1.Service1Client();
            ServiceReference1.VegetableDetails vegetable = new ServiceReference1.VegetableDetails();
            string userOption = String.Empty;
            string vegetableName = String.Empty;
            int vegId;

            while (!userOption.Equals("5"))
            {
                Console.WriteLine("Assignment 3 -- Andy Gnasienco");
                Console.WriteLine("");
                Console.WriteLine("Type the number to select an option");
                Console.WriteLine("1. Create vegetable");
                Console.WriteLine("2. Read all vegetables from the DB");
                Console.WriteLine("3. Update vegetable");
                Console.WriteLine("4. Delete vegetable");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");

                userOption = Console.ReadLine();
                Console.WriteLine("");

                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Insert New Vegetable");
                        Console.WriteLine("Enter ID");
                        Int32.TryParse(Console.ReadLine(), out vegId);
                        Console.WriteLine("Enter Name");
                        vegetableName = Console.ReadLine();

                        vegetable.Veg_ID = vegId;
                        vegetable.Name = vegetableName; ;
                        string s = client.InsertVegDet(vegetable);
                        Console.WriteLine(s);
                        Console.ReadLine();

                        break;
                    case "2":
                        List<VegetableDetails> vegetables = new List<VegetableDetails>();
                        vegetables = client.GetVegetables();

                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            Console.WriteLine("ID: " + vegetables[i].Veg_ID);
                            Console.WriteLine("Name: "+ vegetables[i].Name);
                        }

                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Update vegetable");
                        Console.WriteLine("Enter ID to update");
                        Int32.TryParse(Console.ReadLine(), out vegId);
                        Console.WriteLine("Enter new name");
                        vegetableName = Console.ReadLine();

                        vegetable.Veg_ID = vegId;
                        vegetable.Name = vegetableName; ;
                        s = client.UpdateVegDet(vegetable);
                        Console.WriteLine(s);
                        Console.ReadLine();

                        break;
                    case "4":
                        Console.WriteLine("Delete vegetable");
                        Console.WriteLine("Enter vegetable to delete");
                        vegetableName = Console.ReadLine();

                        vegetable.Name = vegetableName; ;
                        s = client.DeleteVegDet(vegetable);
                        Console.WriteLine(s);
                        Console.ReadLine();
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
