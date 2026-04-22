using System;
using System.Data;

class Program
{
    static void Main()
    {
        ProductData data = new ProductData();

        Console.WriteLine("1. Insert\n2. View\n3. Update\n4. Delete");
        int choice = int.TryParse(Console.ReadLine(), out int c) ? c : 0;

        if (choice == 1)
        {
            Product p = new Product();
            Console.Write("Name: ");
            p.ProductName = Console.ReadLine();
            Console.Write("Category: ");
            p.Category = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = decimal.Parse(Console.ReadLine());

            data.InsertProduct(p);
            Console.WriteLine("Inserted");
        }
        else if (choice == 2)
        {
            DataTable dt = data.GetAllProducts();

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ProductId"]} {row["ProductName"]} {row["Category"]} {row["Price"]}");
            }
        }
        else if (choice == 3)
        {
            Product p = new Product();
            Console.Write("ID: ");
            p.ProductId = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            p.ProductName = Console.ReadLine();
            Console.Write("Category: ");
            p.Category = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = decimal.Parse(Console.ReadLine());

            data.UpdateProduct(p);
            Console.WriteLine("Updated");
        }
        else if (choice == 4)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            data.DeleteProduct(id);
            Console.WriteLine("Deleted");
        }
    }
}