
using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();
using (var _context = new AppDbContext())
{

    //var product = _context.Products.First();

    //if (true)
    //{
    //    _context.Entry(product).Reference(x => x.ProductFeature).Load();
    //}

    //var category = _context.Categories.First();

    //if (true)
    //{
    //    _context.Entry(category).Collection(x => x.Products).Load();
    //}

    //var category = _context.Categories.First();

    //_context.Categories.Remove(category);

    //_context.SaveChanges();

    //var product = new Product
    //{
    //    Name = "silgi1",
    //    Price = 10,
    //    Stock = 10,
    //    Barcode = "100",
    //    Category = new() { Name = "silgiler" },
    //    ProductFeature = new() { Color = "red", Height = 100, Width = 100 }
    //};

    //_context.Products.Add(product);
    //_context.SaveChanges();

    //var category = new Category { Name = "Kalemler" };

    //var product = new Product { Name="kalem1",Price=100,Stock=10,Barcode="10",Category=category};

    //_context.Products.Add(product);
    //_context.SaveChanges();

    //var category = new Category { Name = "Defterler" };

    //category.Products.Add(new() { Name = "Defter1",Price = 100,Stock = 10,Barcode = "10"});

    //_context.Add(category);
    //_context.SaveChanges();

    //var newProduct = new Product { Name = "Kalem 7", Price = 200, Stock = 100, Barcode = "47" };

    //var product = await _context.Products.FirstAsync();

    //Console.WriteLine($"ilk state:{ _context.Entry(product).State}");

    //product.Stock = 1000;

    //_context.Update(new Product() { Id=8,Name="Kalem 8",Price=500,Stock=500,Barcode="777"});

    //_context.Remove(product);
    //_context.Entry(product).State = EntityState.Deleted;

    //_context.Entry(newProduct).State = EntityState.Added;
    //await _context.AddAsync(newProduct);

    //Console.WriteLine($"Son state:{_context.Entry(product).State}");

    //await _context.SaveChangesAsync();

    //Console.WriteLine($"State after save changes:{_context.Entry(product).State}");

    //_context.Products.Add(new() { Name = "kalem 9", Price = 200, Stock = 100, Barcode = "1244" });
    //_context.Products.Add(new() { Name = "kalem 10", Price = 200, Stock = 100, Barcode = "1254" });
    //_context.Products.Add(new() { Name = "kalem 11", Price = 200, Stock = 100, Barcode = "1264" });

    //_context.SaveChanges();

    //var products = await _context.Products.AsNoTracking().ToListAsync();

    //var products = await _context.Products.ToListAsync();

    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;

    //    //p.Stock += 500;

    //    Console.WriteLine($"{p.Id}  : {p.Name} : {p.Price} : {p.Stock} : {state}");
    //});


    //_context.SaveChanges();

    //var products = await _context.Products.Where(x => x.Id == 10).ToListAsync();
}