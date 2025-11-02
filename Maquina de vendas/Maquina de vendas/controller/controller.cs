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

        // Create a shared cart instance to access the non-static Carpreco member
        private static Carro_compras carro = new Carro_compras();

        private static int input_reader(string input)
        {
            if (input is null) { return 0; }
            if (input == "X" || input == "x") { return 1; }
            if (input == "fim") { return 2; }
            foreach (Artg item in artgs) { if (input == item.Nomeartg) { return 3; } }
            return 0;
        }
        public static void Maquina_de_vendas()
        {
            while (true)
            {





                while (true)
                {
                    foreach (Artg item in artgs)
                    {
                        Console.WriteLine($"{item.Nomeartg} {item.Euroartg}€ {item.Quantartg} Quantidade");
                    }
                    Console.WriteLine($"fechar o carrinho: {carro.Carpreco}€");
                    Console.WriteLine(" X");

                    string input = Console.ReadLine();

                    int result = input_reader(input);

                    if (result == 0)
                    {
                        Console.WriteLine("opção inválida escolha novamente");
                        break;
                    }
                    else if (result == 1)
                    {
                        Console.WriteLine("Cancelada a compra.");
                        break;
                    }
                    else if (result == 2)
                    {
                        Console.WriteLine($"Fim da transação prosseguindo para o pagamento de valor: €{carro.Carpreco}");
                        foreach (Artg item in artgs)
                        {
                            if (input == item.Nomeartg)
                            {
                                Console.WriteLine($"{carro.Carpreco}€ X");
                                double pagamento = Convert.ToDouble(Console.ReadLine());
                                if (pagamento < carro.Carpreco)
                                {
                                    Console.WriteLine("Pagamento insuficiente.");
                                }
                                else if (pagamento >= carro.Carpreco)
                                {
                                    double troco = pagamento - carro.Carpreco;
                                    Console.WriteLine($"Pagamento aceite. Troco: {troco}€");
                                }
                                else if (pagamento == carro.Carpreco)
                                {
                                    Console.WriteLine("Pagamento efetuado com sucesso.");
                                }
                            }
                            break;
                        }
                    }
                    else if (result == 3)
                    {
                        foreach (Artg item in artgs)
                        {
                            int stock = 0;
                            if (input == item.Nomeartg)
                            {
                                Console.WriteLine($"{item.Nomeartg} {item.Euroartg}€ {item.Quantartg} Quantidade {carro.Carpreco}€ X");
                            stock = item.Quantartg;
                                Console.WriteLine("Quantas unidades desaja?");
                            int number = Convert.ToInt32(Console.ReadLine());

                            double preço = item.Euroartg * number;

                            if (number >= stock)
                            {
                                Console.WriteLine("Não existem tantas unidades em stock.");
                                break;
                            }
                            else if (number < 0 || number > 99)
                            {
                                Console.WriteLine("Numero escolhido ultreapssa ou é menor que a escala usada.");
                                break;
                            }
                            else
                            {
                                carro.Carnomes.Add(item.Nomeartg);
                                carro.Preço_calc(preço);
                                carro.Qunat_calc(number);

                                Console.WriteLine($"{item.Nomeartg} adicionado ao carrinho");
                            }
                            }
                        
                            
                        }
                    }
                }
            }
        }
    }
}