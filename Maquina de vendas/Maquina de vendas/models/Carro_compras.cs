public class Carro_compras
{
    public List<string> carnomes = new List<string>();
    public double carpreco = 0;
    public int carquant = 0;

    static double Preço_calc(double preco)
    {
        carpreco += preco;
        return carpreco;
    }

    static bool validity_check(int num)
    {  
        if (num < 00 && num > 99)
        {
            return false;
        }
        //else if foreach (Artg item in artgs){if (num > item.Quantartg)return false;}}
        return true;
    }

    ShowCart(){
        foreach (string nome in carnomes){
            Console.WriteLine(nome)
        }
    }
}