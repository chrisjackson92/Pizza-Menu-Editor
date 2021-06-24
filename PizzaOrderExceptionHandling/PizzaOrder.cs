using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderExceptionHandling
{
    class PizzaOrder
    {
        int size;
        string toppings;
        decimal price;

        public PizzaOrder()
        {
            size = 12;
            toppings = "cheese";
            price = 8m;
        }

        public PizzaOrder(int tempSize, string tempToppings, decimal tempPrice)
        {
            Size = tempSize;
            toppings = tempToppings;
            Price = tempPrice;
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value >= 12 & value <= 16)
                {
                    size = value;
                }
                else
                {
                    //throw new FormatException("Size must be entered as an integer.");
                    throw new Exception("Size must be between 12 and 16.");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    //throw new FormatException("Price must be enterted in a number format.");
                    throw new Exception("Price must be a positive number.");
                }
            }
        }

        public string PizzaInfo()
        {
            string info = $"Size:     {size}\n" +
                          $"Toppings: {toppings}\n" +
                          $"Price:    {price:C}\n";
            return info;
        }
    }
}
