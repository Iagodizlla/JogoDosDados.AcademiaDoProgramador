using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDosDadosConsoleApp
{
    internal class CalcularPosicoes
    {
        public static int PosicaoUsuario(int PosicaoU, int dado)
        {
            PosicaoU += dado;
            if (PosicaoU == 10)
            {
                PosicaoU += 3;
                Console.WriteLine("Voce achou um taxi e andou mais 3 casas");
            }
            else if (PosicaoU == 15)
            {
                PosicaoU -= 2;
                Console.WriteLine("Voce foi roubado e voltou 2 casas");
            }
            else if (PosicaoU == 20)
            {
                PosicaoU += 2;
                Console.WriteLine("Voce pegou uma carona e andou mais 2 casas");
            }
            else if (PosicaoU == 25)
            {
                PosicaoU -= 3;
                Console.WriteLine("Voce foi sequestrado e voltou 3 casas");
            }
            return PosicaoU;
        }
        public static int PosicaoRobo(int PosicaoC, int dado)
        {
            PosicaoC += dado;
            if (PosicaoC == 10)
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
                Console.WriteLine("O robo foi roubado e voltou 2 casas");
            }
            else if (PosicaoC == 25)
            {
                PosicaoC += 3;
                Console.WriteLine("O robo achou um taxi e andou mais 3 casas");
            }
            return PosicaoC;
        }
    }
}
