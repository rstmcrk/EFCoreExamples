
using EFCoreExamples.DataBaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

using (var dbContext = new EfcoreDataBaseFirstDbContext())
{
    var products = await dbContext.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} : {p.Name} : {p.Stock} : {p.Price}");
    });

    Console.ReadKey();
}