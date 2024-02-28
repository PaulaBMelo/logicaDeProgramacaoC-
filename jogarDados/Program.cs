using System;

namespace JogarDados {
    class Program 
    {
        //começa inicializando todas as variáveis
        public static string Jogador1;
        public static string Jogador2;

        public static byte PontosJogador1;
        public static byte PontosJogador2;

        public static byte RodadaAtual;

        //escreva os métodos que compoem a classe
        static void Main(string[] args) 
        {
           ConfigurarJogo();
           IniciarRodadas();
        }

        public static void ConfigurarJogo() 
        {
            RodadaAtual = 0;
            CriarJogador();
            AtualizarPlacar();

            console.WriteLine($"A partida será entre os jogadores {Jogador1} e {Jogador2}. Pressione qualquer tecla para começar");
            console.ReadKey();
        }

        public static void CriarJogador()
        {
            PontosJogador1 = 0;
            PontosJogador2 = 0;

            console.WriteLine("Nome do primeiro jogador:");
            Jogador1 = console.ReadLine();

            console.WriteLine("Nome do segundo jogador:");
            Jogador2 = console.ReadLine();

            if(Jogador1 === Jogador2) {
                console.WriteLine("Os jogadores precisam ser diferentes");
            }
        }

        public static void AtualizarPlacar()
        {
            if(RodadaAtual = 0) {
                console.WriteLine("O placar está zerado");
            }

            console.WriteLine($"A pontuação do {Jodador1} é de {PontosJogador1} e a pontuação do {Jodador2} é de {PontosJogador2}");
        }

        public static void IniciarRodadas()
        {
            if (RodadaAtual == 3) {
                FinalizarJogo();
            }
            RodadaAtual++;

            console.WriteLine($"{Jogador1}, aperte enter para realizar a sua jogada");
            console.ReadLine();
            byte JogadaJogador1 = JogarDado();
            console.WriteLine($"{Jogador1}, o número que você tirou é {JogadaJogador1}");

            console.WriteLine($"{Jogador2}, aperte enter para realizar a sua jogada");
            console.ReadLine();
            byte JogadaJogador1 = JogarDado();
            console.WriteLine($"{Jogador2}, o número que você tirou é {JogadaJogador2}");

            if (JogadaJogador1 === JogadaJogador2) {
                console.WriteLine("Empate");
                Console.WriteLine("Pressione ENTER para continuar com o jogo...");
                Console.ReadLine();
            }

            if (JogadaJogador1 > JogadaJogador2) {
                console.WriteLine($"Ponto para {Jogador1}");
                PontosJogador1++;
                Console.WriteLine("Pressione ENTER para continuar com o jogo...");
                Console.ReadLine();
            } 

            if (JogadaJogador2 > JogadaJogador1) {
                console.WriteLine($"Ponto para {Jogador2}");
                PontosJogador2++;
                Console.WriteLine("Pressione ENTER para continuar com o jogo...");
                Console.ReadLine();
            }
            IniciarRodadas();
        }

        public static byte JogarDado()
        {
            Random random = new Random();
            return Convert.ToByte(random.Next(1, 6));
        }

        public static void FinalizarJogo()
        {
            AtualizarPlacar();
            Console.WriteLine("Jogo finalizado!!!");

            if(PontosJogador1 == PontosJogador2)
            {
                Console.WriteLine("Empate!");
            }
            else if(PontosJogador1 > PontosJogador2)
            {
                Console.WriteLine($"O jogador {Jogador1} venceu com {PontosJogador1} pontos!");
            }
            else
            {
                Console.WriteLine($"O jogador {Jogador2} venceu com {PontosJogador2} pontos!");
            }
    }
}
}


