
using Microsoft.EntityFrameworkCore;
namespace SQLLite;

class Program
{
    static void Main(String[] args)
    {

        using var database = new Product();
        database.Database.EnsureCreated();

        Console.WriteLine("Inserting new record");
        Customer customer = new Customer();

        customer.Id = Guid.NewGuid();
        customer.Name = "Jerry";
        customer.Address = "XYZ";
        customer.City = "London";

        database.Customers.Add(customer);
        database.SaveChanges();

        var customers = database.Customers;
        foreach(var cust in customers) 
        {
            Console.WriteLine($"Id:{customer.Id}, Name:{customer.Name}, Address:{customer.Address},City:{customer.City}");
        }

        var remove = database.Customers.FirstOrDefault(x => x.Name.Contains("Tomm"));
        if (remove != null )
        {
            database.Customers.Remove(remove);
            database.SaveChanges();
        }
    }
}

