namespace Desafio_Rocket.Exercicios;

class Nome
{
    public void Entrada()
    {
        Console.Write("Digite o seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine($"\nOlá {nome}! Seja bem-vindo!");

        Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void NomeSobrenome()
    {
        Console.Clear();
        Console.Write("Digite o seu nome: ");
        string? nome = Console.ReadLine();
        Console.Write("\nOtimo agora digite o seu sobrenome: ");
        string? sobrenome = Console.ReadLine();
        
        string nomeCompleto = string.Concat(nome, " " ,sobrenome);
        Console.WriteLine($"\nseu nome completo é {nomeCompleto}");

        Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void Palavras()
    {
        Console.Write("Digite uma palavra: ");
        string? palavras = Console.ReadLine();

        int quantidade = palavras.Length;

        Console.WriteLine($"A palavra {palavras} tem {quantidade} caracteres");

        Console.WriteLine("\n\nDigite qualquer tecla para continuar...");
        Console.ReadKey();
    }
}

