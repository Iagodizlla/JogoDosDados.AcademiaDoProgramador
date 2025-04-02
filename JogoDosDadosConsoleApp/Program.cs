namespace JogoDosDadosConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "S";
            bool acabou = false;
            CalcularPosicoes CP = new CalcularPosicoes();
            while (true) {
                if (resposta == "N")
                {
                    break;
                }
                else
                {
                    CP.PosicaoC = 0;
                    CP.PosicaoU = 0;
                    acabou = false;
                    while (true)
                    {
                        Cabecalho();
                        DigitarEnter();

                        int dado = GerarNumero();

                        MenuGirar(dado);
                        CP.PosicaoUsuario(dado);

                        DigitarEnter();
                        dado = GerarNumero();

                        MenuGirar(dado);
                        CP.PosicaoRobo(dado);
                        
                        MostarVencedor(CP);

                        Console.Write("Deseja continuar? (S/N): ");
                        resposta = Console.ReadLine()!.ToUpper();

                        AcabarJogo(ref acabou, CP);
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
            return numero.Next(1, 7);
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
        public static void MostarVencedor(CalcularPosicoes CP)
        {
            if (CP.PosicaoC >= 30 && CP.PosicaoU >= 30)
            {
                Console.WriteLine("\nVoce o robo passaram da chegada!!");
                if (CP.PosicaoC > CP.PosicaoU)
                {
                    Console.WriteLine("Mas o robo foi mais longe e venceu!!");
                }
                else if(CP.PosicaoU > CP.PosicaoC)
                {
                    Console.WriteLine("Mas voce foi mais longe e venceu!!");
                }
                else
                {
                    Console.WriteLine("E ficaram na mesma posicao!!!");
                }
                MostrarPosicao(CP);
            }
            else if (CP.PosicaoU >= 30)
            {
                Console.WriteLine("\nParabens, você venceu!!");
                MostrarPosicao(CP);
                return;
            }
            else if (CP.PosicaoC >= 30)
            {
                Console.WriteLine("\nO robo venceu!!");
                MostrarPosicao(CP);
                return;
            }
            else
            {
                MostrarPosicao(CP);
            }
        }
        static void MostrarPosicao(CalcularPosicoes CP)
        {

            Console.WriteLine($"\nO robo esta na posicao: {CP.PosicaoC}");
            Console.WriteLine($"Você está na posição: {CP.PosicaoU}\n");
        }
        static bool AcabarJogo(ref bool acabou, CalcularPosicoes CP)
        {
            if (CP.PosicaoC >= 30 || CP.PosicaoU >= 30)
            {
                acabou = true;
            }
            return acabou;
        }
    }
}