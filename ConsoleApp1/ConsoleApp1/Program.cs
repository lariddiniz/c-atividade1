
/* 1  using System;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valorPorHora = 35.00;
            int horasTrabalhadasPorDia = 8;

         
            double salarioDiario = valorPorHora * horasTrabalhadasPorDia;


            Console.WriteLine($"O salário diário do Joaquim é: R${salarioDiario:F2}");
            Console.ReadKey();
        }
    }
}*/

/* 2 using System;

namespace CalculoBombons
{
    class Program
    {
        static void Main(string[] args)
        {
            int bombonsPorCaixa = 27;
            int caixasCompradas = 16;

            int totalBombons = bombonsPorCaixa * caixasCompradas;

            Console.WriteLine($"Pamela comprou um total de {totalBombons} bombons.");
        }
    }
}*/



/* 3 namespace SomaDeDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, soma;

            Console.WriteLine("Digite o primeiro número inteiro:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine($"A soma de {numero1} e {numero2} é igual a {soma}.");
        }
    }
}*/

/*using System;

namespace CalculoCaixas
{
    class Program
    {
        static void Main(string[] args)
        {
            int garrafasPorCaixa = 20;
            int totalGarrafasVendidas = 300;

            int caixasUsadas = totalGarrafasVendidas / garrafasPorCaixa;

            Console.WriteLine($"Foram usadas {caixasUsadas} caixas para vender {totalGarrafasVendidas} garrafas de água.");
        }
    }
}*/

/*using System;

namespace CalculoServicos
{
    class Program
    {
        static void Main(string[] args)
        {
            const double valorInstalacao = 300.00;
            const double valorLimpeza = 150.00;
            const double valorManutencao = 499.99;
            const double desconto = 50.00;

            double valorTotalServicos = valorInstalacao + valorLimpeza + valorManutencao;
            double valorFinal = valorTotalServicos - desconto;

            Console.WriteLine($"O valor total dos serviços é: R${valorTotalServicos:F2}");
            Console.WriteLine($"Com o desconto de R${desconto:F2}, o valor final a ser pago é: R${valorFinal:F2}");
        }
    }
}*/















