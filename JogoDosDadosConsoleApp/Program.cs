namespace JogoDosDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PosicaoU = 0, PosicaoC = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("__________________________");
                Console.WriteLine("Jogo dos Dados");
                Console.WriteLine("--------------------------\n");

                Console.WriteLine("Digite ENTER para girar o dado");
                Console.ReadLine();

                Random numero = new Random();
                int dado = numero.Next(1, 7);

                Console.WriteLine("__________________________");
                Console.WriteLine($"Giroooou e caiu: {dado}");
                Console.WriteLine("--------------------------");
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

                Console.WriteLine("\nDigite ENTER para o Computador girar o dado");
                Console.ReadLine();
                dado = numero.Next(1, 7);

                Console.WriteLine("__________________________");
                Console.WriteLine($"Giroooou e caiu: {dado}");
                Console.WriteLine("--------------------------");
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
                } else if(PosicaoC == 25)
                {
                    PosicaoC += 3;
                    Console.WriteLine("O robo achou um taxi e andou mais 3 casas");
                }

                Console.WriteLine($"\nO robo esta na posicao: {PosicaoC}");
                Console.WriteLine($"Você está na posição: {PosicaoU}");
                Console.Write("Deseja continuar? (S/N): ");
                string resposta = Console.ReadLine()!.ToUpper();

                if (resposta != "S")
                {
                    break;
                }
            }
        }
    }
}