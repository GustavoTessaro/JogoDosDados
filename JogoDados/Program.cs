// See https://aka.ms/new-console-template for more information
class Program
{

    public static char JogarDeNovo()
    {

        Console.WriteLine("\nDeseja jogar novamente? (s/n)");
        char pergunta = Console.ReadKey().KeyChar;

        if (pergunta != 's' && pergunta != 'S')
        {
            Console.WriteLine("\n\nObrigado por Jogar!");
            return pergunta;
        }
        else
        {
            return pergunta;
        }

    }
    static void Main(string[] args)
    {

        int posicaoJogador = 0, posicaoComputador = 0, dadoJogado = 0;
        bool vezComputador = true;
        bool jogarDenovo = true;
        Random random = new Random();

        Console.WriteLine("Bem-vindo ao jogo de corrida de dados! O objetivo é chegar à posição 30 primeiro.");

        while (posicaoJogador < 30 && posicaoComputador < 30)
        {
            #region Rodada do Jogador

            Console.WriteLine("\nPosição Jogador: " + posicaoJogador);
            Console.WriteLine("Posição Computador: " + posicaoComputador);
            Console.Write("\nAperte qualquer tecla para você jogar!");
            Console.ReadKey();
            Console.Clear();
            vezComputador = true;
            dadoJogado = random.Next(1, 7);
            posicaoJogador += dadoJogado;
            Console.WriteLine("O jogador avançou " + dadoJogado + " casas e está na posição " + posicaoJogador);

            if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15)
            {
                Console.WriteLine("\nMeus parabéns você estava na posição " + posicaoJogador + " e ganhou um avanço de 3 casas!");
                posicaoJogador += 3;
            }

            if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
            {
                Console.WriteLine("\nQue pena você caiu numa armadilha! você estava na posição " + posicaoJogador + " e recuou 2 casas!");
                posicaoJogador -= 2;
            }

            if (posicaoJogador >= 30)
            {
                Console.WriteLine("\nParabéns, você venceu a corrida!");
                char jogarNovamente = JogarDeNovo();

                if (jogarNovamente != 's' && jogarNovamente != 'S')
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    posicaoJogador = 0;
                    posicaoComputador = 0;
                    continue;
                }
            }

            if (dadoJogado == 6)
            {
                Console.WriteLine("\nVocê jogou um 6! Jogue novamente.");
                continue;
            }

            #endregion

            #region  Rodada do Computador

            while (vezComputador == true)
            {
                Console.WriteLine("\nPosição Jogador: " + posicaoJogador);
                Console.WriteLine("Posição Computador: " + posicaoComputador);
                Console.Write("\nAperte qualquer tecla para o Computador jogar!");
                Console.ReadKey();
                Console.Clear();
                dadoJogado = random.Next(1, 7);
                posicaoComputador += dadoJogado;
                Console.WriteLine("O computador avançou " + dadoJogado + " casas e está na posição " + posicaoComputador);

                if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
                {
                    Console.WriteLine("\nQue pena! o computador estava na posição " + posicaoComputador + " e ganhou um avanço de 3 casas!");
                    posicaoComputador += 3;
                }

                if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                {
                    Console.WriteLine("\nQue sorte! o computador caiu numa armadilha! Computador estava na posição " + posicaoComputador + " e recuou 2 casas!");
                    posicaoComputador -= 2;
                }

                if (posicaoComputador >= 30)
                {
                    Console.WriteLine("\nO computador venceu a corrida! Tente novamente.");
                    jogarDenovo = false;
                    break;
                }

                if (dadoJogado == 6)
                {
                    Console.WriteLine("\nO computador jogou um 6! Ele joga novamente.");
                    continue;
                }

                vezComputador = false;

            }

            #endregion

            if (jogarDenovo == false)
            {
                char jogarNovamente = JogarDeNovo();

                if (jogarNovamente != 's' && jogarNovamente != 'S')
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    posicaoJogador = 0;
                    posicaoComputador = 0;
                    jogarDenovo = true;
                    continue;
                }

            }

        }

    }

}
