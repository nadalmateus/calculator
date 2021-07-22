using System;

namespace csharp_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("-------------------------------");

            Console.WriteLine("Selecione um opçõa");
            short opcaoSelecionada = short.Parse(Console.ReadLine());

            switch (opcaoSelecionada)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisão(); break;
                case 5: break;

            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("Segundo Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("Primeiro Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }
        static void Divisão()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("Primeiro Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("");

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("Primeiro Valor");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");


            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }

    }
}
