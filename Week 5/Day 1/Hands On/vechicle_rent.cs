using System;

class Vehicle
{
    private double rentalRatePerDay;

    public string Brand { get; set; }

    public double RentalRatePerDay
    {
        get { return rentalRatePerDay; }
        set
        {
            if (value > 0)
                rentalRatePerDay = value;
        }
    }

    public virtual double CalculateRental(int days)
    {
        return rentalRatePerDay * days;
    }
}

class Car : Vehicle
{
    public override double CalculateRental(int days)
    {
        double total = RentalRatePerDay * days;
        return total + 500;
    }
}

class Bike : Vehicle
{
    public override double CalculateRental(int days)
    {
        double total = RentalRatePerDay * days;
        return total - (total * 0.05);
    }
}