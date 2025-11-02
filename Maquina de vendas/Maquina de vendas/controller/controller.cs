using System;
using System.Collections.Generic;

namespace Maquina_de_vendas
{
    public class Controller
    {
        private static double carpreco = 0;
        private static List<Artg> artgs = new List<Artg>
        {
            new Artg { Nomeartg = "Água", Euroartg = 4.00, Quantartg = 5 },
            new Artg { Nomeartg = "batatas fritas", Euroartg = 10.00, Quantartg = 8 },
            new Artg { Nomeartg = "bolachas", Euroartg = 9.00, Quantartg = 15 }
        };

        public static void DisplayProducts()
        {
            foreach (Artg item in artgs)
            {
                Console.WriteLine($"{item.Nomeartg} - €{item.Euroartg} - Qty: {item.Quantartg}");
            }
            Console.WriteLine($"Total no carrinho: €{carpreco:F2}");
            Console.WriteLine(" X");
        }

        public static void AddToCart(double price)
        {
            carpreco += price;
        }

        public static double GetCartTotal()
        {
            return carpreco;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Maquina_de_vendas
{
    public class Controller
    {
        private static double carpreco = 0;
        private static List<Artg> artgs = new List<Artg>
        {
            new Artg { Nomeartg = "Água", Euroartg = 4.00, Quantartg = 5 },
            new Artg { Nomeartg = "batatas fritas", Euroartg = 10.00, Quantartg = 8 },
            new Artg { Nomeartg = "bolachas", Euroartg = 9.00, Quantartg = 15 }
        };

        public static void DisplayProducts()
        {
            foreach (Artg item in artgs)
            {
                Console.WriteLine($"{item.Nomeartg} - €{item.Euroartg} - Qty: {item.Quantartg}");
            }
            Console.WriteLine($"Total no carrinho: €{carpreco:F2}");
            Console.WriteLine(" X");
        }

        public static void AddToCart(double price)
        {
            carpreco += price;
        }

        public static double GetCartTotal()
        {
            return carpreco;
        }
    }
}
using System.Security.Cryptography.X509Certificates;

List<Artg> artgs = new List<Artg>
    {
        new Artg { Nomeartg = "Água", Euroartg = 4.00, Quantartg = 5 },
        new Artg { Nomeartg = "batatas fritas", Euroartg = 10.00, Quantartg = 8 },
        new Artg { Nomeartg = "bolachas", Euroartg = 9.00, Quantartg = 15 }
    };




    
    foreach (Artg item in artgs)
    {
        Console.Write($"{item.Nomeartg} - €{item.Euroartg} - Qty: {item.Quantartg}");
    }
    Console.WriteLine($" carpreco");
    Console.WriteLine(" X");
using System;
using System.Collections.Generic;

namespace Maquina_de_vendas
{
    public class Controller
    {
        private static double carpreco = 0;
        private static List<Artg> artgs = new List<Artg>
        {
            new Artg { Nomeartg = "Água", Euroartg = 4.00, Quantartg = 5 },
            new Artg { Nomeartg = "batatas fritas", Euroartg = 10.00, Quantartg = 8 },
            new Artg { Nomeartg = "bolachas", Euroartg = 9.00, Quantartg = 15 }
        };

        public static void DisplayProducts()
        {
            foreach (Artg item in artgs)
            {
                Console.WriteLine($"{item.Nomeartg} - €{item.Euroartg} - Qty: {item.Quantartg}");
            }
            Console.WriteLine($"Total no carrinho: €{carpreco:F2}");
            Console.WriteLine(" X");
        }

        public static void AddToCart(double price)
        {
            carpreco += price;
        }

        public static double GetCartTotal()
        {
            return carpreco;
        }
    }
}
