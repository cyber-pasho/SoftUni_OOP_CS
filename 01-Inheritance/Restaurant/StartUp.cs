namespace Restaurant
{
    public class StartUp
    {
        public static void Main()
        {

        }
    }

    public class Product
    {
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    }

    public class Beverage
        : Product

    {
        public Beverage(string name, decimal price, double milliliters)
            : base(name, price)
        {
            Milliliters = milliliters;
        }

        public double Milliliters { get; set; }
    }

    public class ColdBeverage
        : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {

        }
    }
    public class HotBeverage
        : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {

        }
    }
    public class Coffee
        : HotBeverage
    {
        public const double CoffeeMilliliters = 50;
        public const decimal CoffeePrice = 3.50m;
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; set; }

    }

    public class Tea
        : HotBeverage
    {
        public Tea(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {

        }

    }

    public class Food
        : Product
    {
        public Food(string name, decimal price, double grams)
            : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }

    public class MainDish
        : Food
    {
        public MainDish(string name, decimal price, double grams)
            : base(name, price, grams)
        {

        }
    }
    public class Fish
        : MainDish
    {
        public Fish(string name, decimal price)
            : base(name, price, grams : 22)
        {
        }
    }
    public class Starter
        : Food
    {
        public Starter(string name, decimal price, double grams)
            : base(name, price, grams)
        {

        }
    }
    public class Soup
        : Starter
    {
        public Soup(string name, decimal price, double grams)
            : base(name, price, grams)
        {

        }
    }
    public class Dessert
        : Food
    {
        public Dessert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories { get; set; }
    }
    public class Cake
        : Dessert
    {
        public const decimal CakePrice = 5m;
        public Cake(string name)
            : base(name, price: CakePrice, grams : 250, calories : 1000)
        {
            Price = CakePrice;
        }
    }
}