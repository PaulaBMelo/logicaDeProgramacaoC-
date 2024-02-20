using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();            
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto da divisão");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("0 - Sair");

            console.WriteLine("\n\nDigite a opção desejada:")
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtrair();                    
                    break;
                case "3":
                    Multiplicar();                    
                    break;
                case "4":
                    Dividir();                    
                    break;
                case "5":
                    EncontrarRestoDivisao();                    
                    break;
                case "6":
                    CalcularPotenciacao();                    
                    break;
                case "0":
                    break;
                default:
                    Menu();
                    break;
            }
        }

        public static void Somar() 
        {
            double valor1, valor2;

            console.WriteLine("Digite o primeiro valor:")
            valor1 = double.Parse(console.ReadLine());
            console.WriteLine("Digite o segundo valor:")
            valor2 = double.Parse(console.ReadLine());

            console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
            console.ReadLine();
            Menu();
        }

        public static void Subtrair() 
        {
            double valor1, valor2;

            console.WriteLine("Digite o primeiro valor:")
            valor1 = double.Parse(console.ReadLine());
            console.WriteLine("Digite o segundo valor:")
            valor2 = double.Parse(console.ReadLine());

            console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
            console.ReadLine();
            Menu();
        }

        public static void Multiplicar() 
        {
            double valor1, valor2;

            console.WriteLine("Digite o primeiro valor:")
            valor1 = double.Parse(console.ReadLine());
            console.WriteLine("Digite o segundo valor:")
            valor2 = double.Parse(console.ReadLine());

            console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
            console.ReadLine();
            Menu();
        }

        public static void Dividir() 
        {
            double valor1, valor2;

            console.WriteLine("Digite o dividendo:")
            dividendo = double.Parse(console.ReadLine());
            console.WriteLine("Digite o divisor:")
            divisor = double.Parse(console.ReadLine());

            if (divisor != 0) 
            {
                console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
            } else {
                console.WriteLine("O divisor precisa ser diferente de 0")
            }
            console.ReadLine();
            Menu();
        }

        public static void EncontrarRestoDivisao() 
        {
            double valor1, valor2;

            console.WriteLine("Digite o dividendo:")
            dividendo = double.Parse(console.ReadLine());
            console.WriteLine("Digite o divisor:")
            divisor = double.Parse(console.ReadLine());

            if (divisor != 0) 
            {
                console.WriteLine($"{valor1} % {valor2} = {valor1 % valor2}");
            } else {
                console.WriteLine("O divisor precisa ser diferente de 0")
            }
            console.ReadLine();
            Menu();
        }

        public static void CalcularPotenciacao() 
        {
            double valor1, valor2;

            console.WriteLine("Digite a base:")
            base = double.Parse(console.ReadLine());
            console.WriteLine("Digite o expoente:")
            expoente = double.Parse(console.ReadLine());

            console.WriteLine($"{base} elevado a {expoente} = {Math.Pow(base, expoente)}");
            console.ReadLine();
            Menu();
        }
    }
}