public class Program
{ 
    public static void Main(string[] args)
    {
       var p = new ProductAnotherDerived();
        Console.WriteLine($"p.GetPrice(): {p.GetPrice()}");

        Console.ReadLine();
    }
}


public abstract class  ProductBase
{
    public virtual decimal GetPrice()
    {
        return 10.0m;
    }

    public abstract string GetProductName();
}


public class ProductDerived : ProductBase
{
    public override decimal GetPrice()
    {
        return base.GetPrice() + 2.0m;
    }

    public override string GetProductName()
    {
        return "ProductDerived";
    }
}

public class ProductAnotherDerived : ProductDerived
{
    public override decimal GetPrice()
    {
        return base.GetPrice() + 3.0m;
    }

    public override string GetProductName()
    {
        return "ProductAnotherDerived";
    }
}