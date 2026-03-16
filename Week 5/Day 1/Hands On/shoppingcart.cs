using System;
class Product
{
    private double price;
    public string Name { get; set; }
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
        }
    }
    public virtual double CalculateDiscount()
    {
        return Price;
    }
}
class Electronics : Product
{
    public override double CalculateDiscount()
    {
        return Price - (Price * 0.05);
    }
}
class Clothing : Product
{
    public override double CalculateDiscount()
    {
        return Price - (Price * 0.15);
    }
}