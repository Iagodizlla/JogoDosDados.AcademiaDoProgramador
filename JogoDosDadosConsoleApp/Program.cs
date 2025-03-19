namespace JogoDosDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            int PosicaoU = 0, PosicaoC = 0;
            bool acabou = false;
            while (true) {
                if (resposta == "N")
                {
                    break;
                }
                else
                {
                    PosicaoU = 0;
                    PosicaoC = 0;
                    acabou = false;
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
                        
                        MostarVencedor(PosicaoU, PosicaoC);

                        Console.Write("Deseja continuar? (S/N): ");
                        resposta = Console.ReadLine()!.ToUpper();

                        acabou = AcabarJogo(acabou, PosicaoC, PosicaoU);
                        if (acabou == true || resposta == "N")
                        {
                            break;
                        }
                    }
                }
            }
        }
        public static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Jogo dos Dados");
            Console.WriteLine("------------------------------------\n");
        }
        public static int GerarNumero()
        {
            Random numero = new Random();
            int dado = numero.Next(1, 7);
            return dado;
        }
        public static void MenuGirar(int dado)
        {
            Console.WriteLine("____________________________________");
            Console.WriteLine($"Giroooou e caiu: {dado}");
            Console.WriteLine("------------------------------------");
        }
        public static void DigitarEnter()
        {
            Console.Write("\nDigite ENTER para girar o dado");
            Console.ReadLine();
        }
        static void MostarVencedor(int PosicaoU, int PosicaoC)
        {
            if (PosicaoC >= 30 && PosicaoU >= 30)
            {
                Console.WriteLine("\nVoce o robo passaram da chegada!!");
                if (PosicaoC > PosicaoU)
                {
                    Console.WriteLine("Mas o robo foi mais longe e venceu!!");
                }
                else if(PosicaoU > PosicaoC)
                {
                    Console.WriteLine("Mas voce foi mais longe e venceu!!");
                }
                else
                {
                    Console.WriteLine("E ficaram na mesma posicao!!!");
                }
                MostrarPosicao(PosicaoC, PosicaoU);
            }
            else if (PosicaoU >= 30)
            {
                Console.WriteLine("\nParabens, você venceu!!");
                MostrarPosicao(PosicaoC, PosicaoU);
                return;
            }
            else if (PosicaoC >= 30)
            {
                Console.WriteLine("\nO robo venceu!!");
                MostrarPosicao(PosicaoC, PosicaoU);
                return;
            }
            else
            {
                MostrarPosicao(PosicaoC, PosicaoU);
            }
        }
        static void MostrarPosicao(int PosicaoC, int PosicaoU)
        {

            Console.WriteLine($"\nO robo esta na posicao: {PosicaoC}");
            Console.WriteLine($"Você está na posição: {PosicaoU}\n");
        }
        static bool AcabarJogo(bool acabou, int PosicaoC, int PosicaoU)
        {
            if (PosicaoC >= 30 || PosicaoU >= 30)
            {
                acabou = true;
            }
            return acabou;
        }
    }
}