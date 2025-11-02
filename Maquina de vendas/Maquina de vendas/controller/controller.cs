using System;
using System.Collections.Generic;

namespace Maquina_de_vendas
{

    public class Controller
    {
        private static List<Artg> artgs = new List<Artg>
        {
            new Artg { Nomeartg = "Água", Euroartg = 4.00, Quantartg = 5 },
            new Artg { Nomeartg = "batatas fritas", Euroartg = 10.00, Quantartg = 8 },
            new Artg { Nomeartg = "bolachas", Euroartg = 9.00, Quantartg = 15 }
        };

        public static void Maquina_de_vendas()
        {
            
            foreach (Artg item in artgs)
            {
                Console.WriteLine($"{item.Nomeartg} {item.Euroartg}€ {item.Quantartg} Quantidade");
            }
            Console.WriteLine($"Total no carrinho: €{2}");
            Console.WriteLine(" X");
        }
    }
}
