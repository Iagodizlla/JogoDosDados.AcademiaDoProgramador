namespace JogoDosDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PosicaoU = 0, PosicaoC = 0;
            while (true)
            {
                Cabecalho();
                DigitarEnter();

                int dado = GerarNumero();

                MenuGirar(dado);
                PosicaoU = CalcularPosicoes.PosicaoUsuario(PosicaoU, dado);

                DigitarEnter();
                dado = GerarNumero();

                MenuGirar(dado);
                PosicaoC = CalcularPosicoes.PosicaoRobo(PosicaoC, dado);

                MostarPosicao(PosicaoU, PosicaoC);

                Console.Write("Deseja continuar? (S/N): ");
                string resposta = Console.ReadLine()!.ToUpper();

                if (resposta != "S")
                {
                    break;
                }
            }
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("__________________________");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("--------------------------\n");
        }
        static int GerarNumero()
        {
            Random numero = new Random();
            int dado = numero.Next(1, 7);
            return dado;
        }
        static void MenuGirar(int dado)
        {
            Console.WriteLine("__________________________");
            Console.WriteLine($"Giroooou e caiu: {dado}");
            Console.WriteLine("--------------------------");
        }
        static void DigitarEnter()
        {
            Console.WriteLine("Digite ENTER para girar o dado");
            Console.ReadLine();
        }
        static void MostarPosicao(int PosicaoU, int PosicaoC)
        {
            Console.WriteLine($"\nO robo esta na posicao: {PosicaoC}");
            Console.WriteLine($"Você está na posição: {PosicaoU}");
        }
    }
}