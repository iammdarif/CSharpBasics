public class Program
{
    public static void Main(string[] args)
    {
        Product desk = new Desk();
        desk.Price = 10.0m;

        desk.Add();
        desk.Add();

        System.Console.WriteLine($"Total value of desks in stock: {desk.GetTotalValueInStock()}");


        Product drone = new Drone();
        drone.Price = 200.0m;

        ((Drone)drone).QuantityIncremented = 2;
        drone.Add();
        drone.Add();
        System.Console.WriteLine($"Total value of drones in stock: {drone.GetTotalValueInStock()}");

        System.Console.ReadKey();


    }
}

public class TurboDrone : Drone
{
    public TurboDrone()
    {
        
    }
}

public class Drone : Product
{
    public int QuantityIncremented { get; set; }
    public Drone()
    {
        QuantityIncremented = 10;
    }

    public override void Add()
    {
        _quantity += QuantityIncremented;
    }

}

public class Desk : Product
{
    public Desk()
    {

    }


}

public class Product
{
    protected int _quantity = 0;
    public decimal Price { get; set; }

    public Product()
    {

    }

    public virtual void Add()
    {
        _quantity++;
    }

    public void Remove()
    {
        if (_quantity > 0)
            _quantity--;
    }

    public decimal GetTotalValueInStock()
    {
        return _quantity * Price;
    }
}