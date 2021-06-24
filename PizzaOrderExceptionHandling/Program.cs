using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder[] pizzaArray = new PizzaOrder[4];
            pizzaArray[0] = new PizzaOrder();
            pizzaArray[1] = new PizzaOrder(13, "pepperoni", 13);
            pizzaArray[2] = new PizzaOrder(14, "Veggie Style", 14);
            pizzaArray[3] = new PizzaOrder(15, "Meat Lovers", 15);

            int userChoice = 0, pizzaNumber = 0, newSize;
            decimal newPrice = 0m;

            string keepGoing = "y";
            while (keepGoing == "y")
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Change Price");
                Console.WriteLine("2. Change Size");

                Console.WriteLine("");
                Console.WriteLine("Please enter the number of the command:");
                userChoice = int.Parse(Console.ReadLine());

                if(userChoice == 1)
                {
                    try
                    {
                        Console.WriteLine("");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Pizza Number: {i}");
                            Console.WriteLine(pizzaArray[i].PizzaInfo());
                            Console.WriteLine("");
                        }
                        Console.WriteLine("Please enter the pizza number you want to edit");
                        pizzaNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Please enter the new price of the pizza:");
                        newPrice = decimal.Parse(Console.ReadLine());

                        pizzaArray[pizzaNumber].Price = newPrice;

                        Console.WriteLine("");

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Pizza Number: {i}");
                            Console.WriteLine(pizzaArray[i].PizzaInfo());
                            Console.WriteLine("");
                        }
                    }
                    catch(FormatException formatError)
                    {
                        Console.WriteLine("Please enter the price in a decimal format.");
                    }
                    catch(IndexOutOfRangeException indexError)
                    {
                        Console.WriteLine("Please enter a pizza number within the list.");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if(userChoice == 2)
                {
                    try
                    {
                        Console.WriteLine("");
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Pizza Number: {i}");
                            Console.WriteLine(pizzaArray[i].PizzaInfo());
                            Console.WriteLine("");
                        }
                        Console.WriteLine("Please enter the pizza number you want to edit");
                        pizzaNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Please enter the new size of the pizza:");
                        newSize = int.Parse(Console.ReadLine());

                        pizzaArray[pizzaNumber].Size = newSize;

                        Console.WriteLine("");

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine($"Pizza Number: {i}");
                            Console.WriteLine(pizzaArray[i].PizzaInfo());
                            Console.WriteLine("");
                        }
                    }
                    catch (FormatException formatError)
                    {
                        Console.WriteLine("Please enter the size as a integer.");
                    }
                    catch (IndexOutOfRangeException indexError)
                    {
                        Console.WriteLine("Please enter a pizza number within the list.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.WriteLine("Do you wish to continue? (Enter 'y' for yes)");
                keepGoing = Console.ReadLine();
            }
        }
    }
}
