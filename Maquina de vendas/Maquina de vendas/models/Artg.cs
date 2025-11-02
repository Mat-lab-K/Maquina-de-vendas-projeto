public class Artg
{
    public string Nomeartg { get; init; }
    public double Euroartg { get; init; }
    public int Quantartg { get; init; }
}

public class Carro_compras
{
    List<string> carnomes = new List<string>();
    public double carpreco = 0;
    int carquant = 0;
    public void add_item(string nome, double preco)
    {
        carnomes.Add(nome);
        carpreco += preco;
        carquant++;
    }
}