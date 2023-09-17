using System;

public interface ITributavel
{
    double CalcularValorTotal();
}

public class Imovel : ITributavel
{
    private double ValorVenda;
    private double Imposto;

    public Imovel(double valorVenda, bool novo)
    {
        ValorVenda = valorVenda;
        Imposto = novo ? ValorVenda * 0.05 : ValorVenda * 0.15;
    }

    public double CalcularValorTotal() => ValorVenda + Imposto;
}

class Program
{
    static void Main()
    {
        Imovel imovelNovo = new Imovel(200000, true);
        double valorTotalNovo = imovelNovo.CalcularValorTotal();

        Console.WriteLine("Imóvel Novo:");
        Console.WriteLine("Valor Total (com Imposto): R$" + valorTotalNovo);
        Console.WriteLine();

        Imovel imovelUsado = new Imovel(150000, false);
        double valorTotalUsado = imovelUsado.CalcularValorTotal();

        Console.WriteLine("Imóvel Usado:");
        Console.WriteLine("Valor Total (com Imposto): R$" + valorTotalUsado);
    }
}
