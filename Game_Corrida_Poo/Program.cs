using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Game_Corrida_Poo;

namespace Game_Corrida_Poo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
           





            string testoEntrada = "";
            char jogar = '_';


            do {

                int tamanhoDaPista = 100;

                Corredor c1 = new Corredor();
                c1.Nome = AtletaEscolhido.Antonio.ToString();
                Pista p = new Pista(tamanhoDaPista, c1);

                Corredor c2 = new Corredor();
                c2.Nome = AtletaEscolhido.Bianca.ToString();
                Pista p1 = new Pista(tamanhoDaPista, c2);

                Pista p2 = new Pista(tamanhoDaPista, new Corredor(AtletaEscolhido.Carlos.ToString()));

                Boolean ganhou = false;

               



                Console.WriteLine("Corridas & Apostas");

                Console.WriteLine("Faça sua aposta:");
                Console.WriteLine(" [1] para Antonio:\n [2] para Bianca:\n [3] para Carlos");
                int escolha = int.Parse(Console.ReadLine());
                int ganhador = 0;
                string aposta = "";
                int numeroAtleta = 0;

                if (escolha == 1)
                {
                    Console.WriteLine(" Apostou em: " + AtletaEscolhido.Antonio + " | sera representado pelo letra [a]");
                    aposta = AtletaEscolhido.Antonio.ToString();
                    numeroAtleta = 1;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine(" Apostou em: " + AtletaEscolhido.Bianca + " | sera representado pelo letra [b]");
                    aposta = AtletaEscolhido.Bianca.ToString();
                    numeroAtleta = 2;
                }
                else
                {
                    Console.WriteLine(" Apostou em: " + AtletaEscolhido.Carlos + " | sera representado pelo letra [c]");
                    aposta = AtletaEscolhido.Carlos.ToString();
                    numeroAtleta = 3;
                }
                Console.ReadKey();


                while (ganhou == false)


                {
                    Console.Clear();

                    if (p.AtualizarCorrida() == true)
                    {
                        ganhou = true;

                        ganhador = 1;
                    }

                    if (p1.AtualizarCorrida() == true)
                    {
                        ganhou = true;

                        ganhador = 2;
                    }
                    if (p2.AtualizarCorrida() == true)
                    {
                        ganhou = true;



                        ganhador = 3;
                    }
                    p.ExibirPista();
                    p1.ExibirPista();
                    p2.ExibirPista();


                    Console.ReadKey();

                }


                Console.Clear();

                if (p.PosAtleta >= tamanhoDaPista && p1.PosAtleta >= tamanhoDaPista && p2.PosAtleta >= tamanhoDaPista)
                {
                    Console.WriteLine($"Empate entre os atletas 1,2 e 3\n vc apostou no atleta n° {numeroAtleta} nome: {aposta}");
                }
                else if (p.PosAtleta >= tamanhoDaPista && p1.PosAtleta >= tamanhoDaPista && p2.PosAtleta < tamanhoDaPista)
                {
                    Console.WriteLine($"Empate entre os atletas 1 e 2 e atleta 3 perdeu \n vc apostou no atleta n° {numeroAtleta} nome: {aposta}");
                }
                else if (p.PosAtleta >= tamanhoDaPista && p1.PosAtleta > tamanhoDaPista && p2.PosAtleta >= tamanhoDaPista)
                {
                    Console.WriteLine($"Empate entre os atletas 1 e 3 e perdeu o atleta de numero 2 \n vc apostou no atleta n° {numeroAtleta} nome: {aposta}");
                }
                else if (p.PosAtleta < tamanhoDaPista && p1.PosAtleta >= tamanhoDaPista && p2.PosAtleta >= tamanhoDaPista)
                {
                    Console.WriteLine($"Empate entre os atletas 2 e 3 e perdeu o atleta de numer 1 \n vc apostou no atleta n° {numeroAtleta} nome: {aposta}");
                }
                else
                {
                    Console.WriteLine("Parabéns vc ganhou: otima aposta");
                    Console.WriteLine($"o ganhador foi o atleta de numero:{ganhador} \n vc apostou no atleta n° {numeroAtleta} nome: {aposta}");
                }
                Console.ReadKey();


                
                Console.ReadKey();

                Console.WriteLine(" deseja jogar novamente ?\n [s] sim | [n] não");
                testoEntrada = Console.ReadLine().ToLower();
                jogar = testoEntrada.FirstOrDefault();
                Console.WriteLine(jogar);

            } while (jogar == 's');

            
           




           

           













        }
    }
}





