using Desafio_Rocket.Exercicios;

namespace Desafio_Rocket;

class Program
{
    private static Data data = new Data();
    private static Calculo calc = new();
    private static Nome nome = new();
    static void Main(String[] args)
    {
        nome.Entrada();
        nome.NomeSobrenome();

        calc.Soma();
        calc.Subtracao();
        calc.Multiplicacao();
        calc.Divisao();
        calc.Media();

        nome.Palavras();

        data.VerificarPlaca();
        data.DataAtual();
    }
}