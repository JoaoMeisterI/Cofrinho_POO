using System;

public class Calculadora
{
    // Método para somar dois números inteiros
    public int Somar(int a, int b)
    {
        return a + b;
    }

    // Método sobrecarregado para somar dois números decimais
    public double Somar(double a, double b)
    {
        return a + b;
    }

    // Método sobrecarregado para somar três números inteiros
    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    // Método sobrecarregado para multiplicar dois números inteiros
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // Método sobrecarregado para multiplicar dois números decimais
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        // Chamando o método Somar com diferentes tipos de parâmetros
        Console.WriteLine("Soma de inteiros: " + calculadora.Somar(5, 3));
        Console.WriteLine("Soma de decimais: " + calculadora.Somar(5.5, 3.3));
        Console.WriteLine("Soma de três inteiros: " + calculadora.Somar(2, 4, 6));

        // Chamando o método Multiplicar com diferentes tipos de parâmetros
        Console.WriteLine("Multiplicação de inteiros: " + calculadora.Multiplicar(5, 3));
        Console.WriteLine("Multiplicação de decimais: " + calculadora.Multiplicar(5.5, 3.3));
    }
}
