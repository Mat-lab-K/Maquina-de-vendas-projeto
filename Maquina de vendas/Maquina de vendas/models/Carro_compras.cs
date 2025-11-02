public class Carro_compras
{
    public List<string> Carnomes = new List<string>();
    public double Carpreco { get; set; }
    public int Carquant { get; set; }

    public double Preço_calc(double preco)
    {
        Carpreco += preco;
        return Carpreco;
    }

    public int Qunat_calc(int num)
    {
        Carquant += num;
        return Carquant;
    }


    public bool Validity_check(int num)
    {
        if (num < 0 || num > 99)
        {
            return false;
        }
        return true;
    }

    public void ShowCart()
    {
        foreach (string nome in Carnomes)
        {
            Console.WriteLine(nome);
        }
    }
}