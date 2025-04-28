using System.Globalization;

namespace Desafio_Rocket.Exercicios;

internal class Data
{
    public void VerificarPlaca()
    {
        Console.Write("Digite a placa do seu carro: ");
        string? placa = Console.ReadLine();


        if (placa.Length != 7)
            Console.WriteLine("placa invalida;");
        else
            Console.WriteLine("placa valida;");


        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
                Console.WriteLine("placa invalida;");
            else
                Console.WriteLine("placa valida;");

        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
                Console.WriteLine("placa invalida;");
            else
                Console.WriteLine("placa valida;");


        }
    }

    public void DataAtual()
    {
        DateTime agora = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data: ");
        Console.WriteLine("1 - Data completa (dia da semana, dia do mês, ano, hora, minutos e segundos)");
        Console.WriteLine("2 - Apenas a data (dia, mês, ano)");
        Console.WriteLine("3 - Apenas a Hora");
        Console.WriteLine("4 - Data com o mês por extenso");

        Console.Write("\nDigite a opção desejada (1-4): ");
        string? opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine(agora.ToString("dddd, dd 'de' MMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
                break;
            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(agora.ToString("HH:mm"));
                break;
            case "4":
                Console.WriteLine($"{agora:dd} de {agora:MMMM} de {agora:yyyy}");
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }
}
