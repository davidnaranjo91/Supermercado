using Product.Logic;

var product1 = new FixedPriceProduct()
{
    Id = "1010",
    Descripcion = "Vino Gato Negro",
    Price = 4600m,
    Tax = 0.19F
};

var product2 = new FixedPriceProduct()
{
    Id = "2020",
    Descripcion = "Pan Bimbo Artesanal",
    Price = 1560m,
    Tax = 0.19F
};

var product3 = new VariablePriceProduct()
{
    Id = "3030",
    Descripcion = "Queso Holandes",
    Price = 32000M,
    Tax = 0.19F
};

var product4 = new VariablePriceProduct()
{
    Id = "4040",
    Descripcion = "Cabano",
    Price = 18000M,
    Tax = 0.19F
};


var product5 = new VariablePriceProduct()
{
    Id = "5050",
    Descripcion = "Ancheta #1",
    Price = 18000M,
    Tax = 0.19F
};

Console.WriteLine("Products \t\n");
Console.WriteLine("--------------------------------------"\n);

Console.WriteLine($"{product1}\n");
Console.WriteLine($"{product2}\n");
Console.WriteLine($"{product3}\n");
Console.WriteLine($"{product4}\n");
Console.WriteLine($"{product5}\n");

