using System.Xml.Serialization;
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

        int posicaoJogador = 0, posicaoComputador = 0;
        bool vezComputador = true;
        bool jogarDenovo = true;

        Console.WriteLine("Bem-vindo ao jogo de corrida de dados! O objetivo é chegar à posição 30 primeiro.");

        Jogador jogador = new Jogador(posicaoJogador);
        Computador computador = new Computador(posicaoComputador);

        while (jogador.posicaoJogador < 30 && computador.posicaoComputador < 30)
        {
            #region Rodada do Jogador

            vezComputador = jogador.jogadorJoga(computador.posicaoComputador);

            jogador.verificarArmadilhas();

            if (jogador.posicaoJogador >= 30)
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
                    jogador.posicaoJogador = 0;
                    computador.posicaoComputador = 0;
                    continue;
                }
            }

            if (jogador.dadoJogado == 6)
            {
                Console.WriteLine("\nVocê jogou um 6! Jogue novamente.");
                continue;
            }

            #endregion

            #region  Rodada do Computador

            while (vezComputador == true)
            {
                
                computador.computadorJoga(jogador.posicaoJogador);

                computador.verificaArmadilhas();

                if (computador.posicaoComputador >= 30)
                {
                    Console.WriteLine("\nO computador venceu a corrida! Tente novamente.");
                    jogarDenovo = false;
                    break;
                }

                if (computador.dadoJogado == 6)
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
                    jogador.posicaoJogador = 0;
                    computador.posicaoComputador = 0;
                    jogarDenovo = true;
                    continue;
                }

            }

        }

    }

}
