using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosDadosConsoleApp
{
    internal class CalcularPosicoes
    {
        public int PosicaoU { get; set; }
        public int PosicaoC { get; set; }
        public void PosicaoUsuario(int dado)
        {
            while (true)
            {
                PosicaoU += dado;
                if (PosicaoU == 5)
                {
                    PosicaoU += 3;
                    Console.WriteLine("Voce achou um taxi e andou mais 3 casas");
                }
                else if (PosicaoU == 7)
                {
                    PosicaoU -= 2;
                    Console.WriteLine("Voce foi roubado e voltou 2 casas");
                }
                else if (PosicaoU == 10)
                {
                    PosicaoU += 2;
                    Console.WriteLine("Voce pegou uma carona e andou mais 2 casas");
                }
                else if (PosicaoU == 13)
                {
                    PosicaoU -= 3;
                    Console.WriteLine("Voce foi sequestrado e voltou 3 casas");
                }
                else if (PosicaoU == 15)
                {
                    PosicaoU += 2;
                    Console.WriteLine("Voce pegou uma carona e andou mais 2 casas");
                }else if(PosicaoU == 20)
                {
                    PosicaoU -= 2;
                    Console.WriteLine("Voce foi roubado e voltou 2 casas");
                }

                if (dado == 6)
                {
                    Console.WriteLine("Por ter tirado 6, podera jogar de novo!!\n");
                    Program.DigitarEnter();
                    dado = Program.GerarNumero();
                    Program.MenuGirar(dado);
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public void PosicaoRobo(int dado)
        {
            while (true)
            {
                PosicaoC += dado;
                if (PosicaoC == 5)
                {
                    PosicaoC += 3;
                    Console.WriteLine("O robo achou um taxi e andou mais 3 casas");
                }
                else if (PosicaoC == 7)
                {
                    PosicaoC -= 2;
                    Console.WriteLine("O robo foi roubado e voltou 2 casas");
                }
                else if (PosicaoC == 10)
                {
                    PosicaoC += 2;
                    Console.WriteLine("O robo pegou uma carona e andou mais 2 casas");
                }
                else if (PosicaoC == 13)
                {
                    PosicaoC -= 3;
                    Console.WriteLine("O robo foi sequestrado e voltou 3 casas");
                }
                else if (PosicaoC == 15)
                {
                    PosicaoC += 2;
                    Console.WriteLine("O robo pegou uma carona e andou mais 2 casas");
                }
                else if (PosicaoC == 20)
                {
                    PosicaoC -= 2;
                }

                if (dado == 6)
                {
                    Console.WriteLine("Por ter tirado 6, o robo jogara de novo!!\n");
                    Program.DigitarEnter();
                    dado = Program.GerarNumero();
                    Program.MenuGirar(dado);
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}