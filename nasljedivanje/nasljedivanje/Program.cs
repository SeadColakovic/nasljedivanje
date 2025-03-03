using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje
{
    public class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public override string ToString()
        {
            return $"Dessert: {name}, Weight: {weight}, Calories: {calories}";
        }

        public string GetDessertType()
        {
            return "dessert";
        }
    }

}
