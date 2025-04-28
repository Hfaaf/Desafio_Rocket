namespace Desafio_Rocket.Exercicios;

internal class Calculo
{
    public double Soma()
    {
        Console.Clear();
        Console.Write("Digite um valor para somar: ");
        double valor1 = double.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Digite outro valor: ");
        double valor2 = double.Parse(Console.ReadLine() ?? string.Empty);

        double resultado = valor1 + valor2;
        Console.WriteLine($"O Resultado da soma é {resultado}");

        Console.WriteLine("\n\n Digite qualquer tecla para continuar...");
        Console.ReadKey();

        return resultado;
    }

    public double Subtracao()
    {
        Console.Clear();
        Console.Write("Digite um valor para subtrair: ");
        double valor1 = double.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Digite outro valor: ");
        double valor2 = double.Parse(Console.ReadLine() ?? string.Empty);

        double resultado = valor1 - valor2;
        Console.WriteLine($"O Resultado da subtração é {resultado}");

        Console.WriteLine("\n\n Digite qualquer tecla para continuar...");
        Console.ReadKey();

        return resultado;
    }

    public double Multiplicacao()
    {
        Console.Clear();
        Console.Write("Digite um valor para multiplicar: ");
        double valor1 = double.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Digite outro valor: ");
        double valor2 = double.Parse(Console.ReadLine() ?? string.Empty);

        double resultado = valor1 * valor2;
        Console.WriteLine($"O Resultado da Multiplicação é {resultado}");

        Console.WriteLine("\n\n Digite qualquer tecla para continuar...");
        Console.ReadKey();

        return resultado;
    }

    public double Divisao()
    {
        Console.Clear();
        Console.Write("Digite um valor para dividir: ");
        double valor1 = double.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Digite outro valor: ");
        double valor2 = double.Parse(Console.ReadLine() ?? string.Empty);

        double resultado = valor1 / valor2;

        Console.WriteLine($"O Resultado da divisão é {resultado}");

        Console.WriteLine("\n\n Digite qualquer tecla para continuar...");
        Console.ReadKey();

        return resultado;
    }

    public double Media()
    {
        Console.Clear();
        Console.Write("Digite um valor para a nota 1: ");
        double valor1 = double.Parse(Console.ReadLine() ?? string.Empty);

        Console.Write("Digite um valor para a nota 2: ");
        double valor2 = double.Parse(Console.ReadLine() ?? string.Empty);

        double resultado = (valor1 + valor2) / 2;
        Console.WriteLine($"A media é {resultado}");

        Console.WriteLine("\n\n Digite qualquer tecla para continuar...");
        Console.ReadKey();

        return resultado;
    }
}

