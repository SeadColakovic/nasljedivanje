using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanjeIPolimorfizam
{
    using System;

    public class Dessert
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Dessert: {Name}, Price: {Price}";
        }
    }

    public class Cake : Dessert
    {
        public bool ContainsGluten { get; set; }
        public string CakeType { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Contains Gluten: {ContainsGluten}, Cake Type: {CakeType}";
        }

        public string GetDessertType()
        {
            return $"{CakeType} cake";
        }
    }

    public class IceCream : Dessert
    {
        public string Flavour { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Flavour: {Flavour}, Color: {Color}";
        }

        public string GetDessertType()
        {
            return "ice cream";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cake cake = new Cake
            {
                Name = "Birthday Cake",
                Price = 20.0,
                ContainsGluten = true,
                CakeType = "birthday"
            };

            IceCream iceCream = new IceCream
            {
                Name = "Vanilla Ice Cream",
                Price = 5.0,
                Flavour = "vanilla",
                Color = "white"
            };

            Console.WriteLine(cake.ToString());
            Console.WriteLine(cake.GetDessertType());

            Console.WriteLine(iceCream.ToString());
            Console.WriteLine(iceCream.GetDessertType());
        }
    }

}
