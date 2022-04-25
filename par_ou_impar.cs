using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int EscolhaParImpar, NumeroJogadaComputador, NumeroJogadaUsuario, NumeroPlacarComputador = 0, NumeroPlacarUsuario = 0;

            try 
            {
            Console.WriteLine ("Você quer Par ou Impar?/n");
            Console.WriteLine ("0 - Par/n");
            Console.WriteLine ("1 - Impar/n");
            EscolhaParImpar = int.Parse(Console.ReadLine());

            if(EscolhaParImpar == 0); 
            {
                NumeroJogadaComputador = new.Random().Next(0, 100);
                Console.WriteLine ("Faça sua jogada (escolha seu número)/n");
                NumeroJogadaUsuario = int.Parse(Console.ReadLine());

                if ((NumeroJogadaComputador + NumeroJogadaUsuario) % 2 == 0); 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine ("Você jogou o número {0}/n", NumeroJogadaUsuario);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("O Computador jogou o número {0}/n", NumeroJogadaComputador);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("O resultado foi/n. Você ganhou!!!", NumeroJogadaUsuario + NumeroJogadaComputador);
                    NumeroPlacarUsuario = NumeroPlacarUsuario + 1;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine ("Você jogou o número {0}/n", NumeroJogadaUsuario);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("O Computador jogou o número {0}/n", NumeroJogadaComputador);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("O resultado foi/n. O computador ganhou!!!", NumeroJogadaUsuario + NumeroJogadaComputador);
                    NumeroPlacarComputador = NumeroPlacarComputador + 1;
                }
            }
            else if(EscolhaParImpar == 1); 
            {
                NumeroJogadaComputador = new.Random().Next(0, 100);
                Console.WriteLine ("Faça sua jogada (escolha seu número)/n");
                NumeroJogadaUsuario = int.Parse(Console.ReadLine());

                if ((NumeroJogadaComputador + NumeroJogadaUsuario) % 2 != 0); 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine ("Você jogou o número {0}/n", NumeroJogadaUsuario);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("O Computador jogou o número {0}/n", NumeroJogadaComputador);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("O resultado foi/n. Você ganhou!!!", NumeroJogadaUsuario + NumeroJogadaComputador);
                    NumeroPlacarUsuario = NumeroPlacarUsuario + 1;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine ("Você jogou o número {0}/n", NumeroJogadaUsuario);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("O Computador jogou o número {0}/n", NumeroJogadaComputador);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("O resultado foi/n. O computador ganhou!!!", NumeroJogadaUsuario + NumeroJogadaComputador);
                    NumeroPlacarComputador = NumeroPlacarComputador + 1;
                }
            }
                else 
                Console.WriteLine ("Escolha inválida/n");
                
            catch ( Exception ex); 
            {
                Console.WriteLine ("O programa teve um erro - {0}" ex.Menssage);
                trown ex;

            }

        }
    }
}
