

namespace Maquina_de_vendas
{

    public class Controller
    {
        private static List<Artg> artgs = new List<Artg>
        {
            new Artg { Nomeartg = "Refrigerante", Euroartg = 1.80, Quantartg = 5 },
            new Artg { Nomeartg = "Batata Frita", Euroartg = 2.00, Quantartg = 5 },
            new Artg { Nomeartg = "Água 500ml", Euroartg = 1.20, Quantartg = 5 },
            new Artg { Nomeartg = "Bolachas", Euroartg = 1.60, Quantartg = 5 },
            new Artg { Nomeartg = "Café", Euroartg = 1.00, Quantartg = 5 },
            new Artg { Nomeartg = "Chocolate Barato", Euroartg = 0.80, Quantartg = 5 },
            new Artg { Nomeartg = "Barra de Cereal", Euroartg = 1.30, Quantartg = 5 }	
        };
        private static Carro_compras carro = new Carro_compras();

        private static int input_reader(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) { return 0; }
            if (input == "X" || input == "x") { return 1; }
            if (input == "fim"||input == "Fim" ) { return 2; }
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
                        Console.WriteLine($"{item.Nomeartg} {item.Euroartg}€ ");
                    }
                    Console.WriteLine($"Total do carrinho {carro.Carpreco}€");
                    Console.WriteLine("X");

                    string input = Console.ReadLine();

                    int result = input_reader(input);

                    if (result == 0)
                    {
                        Console.WriteLine("opção inválida escolha novamente.\n");
                        break;
                    }
                    else if (result == 1)
                    {
                        Console.WriteLine("Cancelada a compra.\n");
                        break;
                    }
                    else if (result == 2)
                    {
                        Console.WriteLine($"Fim da transação prosseguindo para o pagamento de valor: €{carro.Carpreco}\n");
                        foreach (Artg item in artgs)
                        {
                            if (input == item.Nomeartg)
                            {
                                Console.WriteLine($"{carro.Carpreco}€ \nX");
                                double pagamento = Convert.ToDouble(Console.ReadLine());
                                if (pagamento < carro.Carpreco)
                                {
                                    Console.WriteLine("Pagamento insuficiente.\n");
                                }
                                else if (pagamento >= carro.Carpreco)
                                {
                                    double troco = pagamento - carro.Carpreco;
                                    Console.WriteLine($"Pagamento aceite. Troco: {troco}€\n");
                                }
                                else if (pagamento == carro.Carpreco)
                                {
                                    Console.WriteLine("Pagamento efetuado com sucesso.\n");
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
                                Console.WriteLine($"{item.Nomeartg} {item.Euroartg}€  €\n X");
                            stock = item.Quantartg;
                                Console.WriteLine("Quantas unidades desaja?\n");
                            int number = Convert.ToInt32(Console.ReadLine());

                            double preço = item.Euroartg * number;

                            if (number >= stock)
                            {
                                Console.WriteLine("Não existem tantas unidades em stock.\n");
                                break;
                            }
                            else if (number < 0 || number > 99)
                            {
                                Console.WriteLine("Numero escolhido ultreapssa ou é menor que a escala usada.\n");
                                break;
                            }
                            else
                            {
                                carro.Carnomes.Add(item.Nomeartg);
                                carro.Preço_calc(preço);
                                carro.Qunat_calc(number);

                                Console.WriteLine($"{item.Nomeartg} adicionado ao carrinho.\n");
                            }
                            }
                        
                            
                        }
                    }
                }
            }
        }
    }
}