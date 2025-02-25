namespace linq;
 
public class Program
{
    static void Main(string[] args)
    {

        //var Output = RandomProductGeneration(10);
        //foreach(var item in Output)
        //{
        //    Console.WriteLine($"Id={item.Id}, Name={item.Name}, Description={item.Description}, ProductId={item.ProductId}");
        //}

        var LinqOutput = RandomProductGeneration(20);

        var Food = LinqOutput.First(x => x.ProductId > 25);      

        Console.WriteLine($"Id={Food.Id}, Name={Food.Name}, Description={Food.Description}, ProductId={Food.ProductId}");

        var Order = LinqOutput.OrderBy(x => x.ProductId);

        foreach (var item in Order)
        {
            Console.WriteLine($"Id={item.Id}, Name={item.Name}, Description={item.Description}, ProductId={item.ProductId}");
        }


        static List<Product> RandomProductGeneration(int count)
        {
            var products = new List<Product>();
            var random = new Random();
            for(int i = 0; i < count; i++) 
            {
                products.Add(new Product
                {
                    Id = Guid.NewGuid(),
                    Name = $"Name{ i + 1 }",
                    Description = $"Description{i+1}",
                    ProductId = random.Next(10,50) ,
                });
            }

            return products;
        }
    }
}