class Jogador
{
    public int posicaoJogador { get; set; }
    public int dadoJogado { get; set; }
    public Random random = new Random();
    public Jogador(int posicaoJogadorP)
    {
        posicaoJogador = posicaoJogadorP;
        dadoJogado = 0;
    }

    public bool jogadorJoga(int posicaoComputador)
    {
        Console.WriteLine("\nPosição Jogador: " + this.posicaoJogador);
        Console.WriteLine("Posição Computador: " + posicaoComputador);
        Console.Write("\nAperte qualquer tecla para você jogar!");
        Console.ReadKey();
        Console.Clear();
        bool vezComputador = true;
        this.dadoJogado = random.Next(1, 7);
        this.posicaoJogador += dadoJogado;
        Console.WriteLine("O jogador avançou " + dadoJogado + " casas e está na posição " + this.posicaoJogador);

        return vezComputador;
    }

    public void verificarArmadilhas()
    {
        if (this.posicaoJogador == 5 || this.posicaoJogador == 10 || this.posicaoJogador == 15)
        {
            Console.WriteLine("\nMeus parabéns você estava na posição " + this.posicaoJogador + " e ganhou um avanço de 3 casas!");
            this.posicaoJogador += 3;
        }

        if (this.posicaoJogador == 7 || this.posicaoJogador == 13 || this.posicaoJogador == 20)
        {
            Console.WriteLine("\nQue pena você caiu numa armadilha! você estava na posição " + this.posicaoJogador + " e recuou 2 casas!");

            if (this.posicaoJogador == 7)
            {
                Console.WriteLine("\nMeus parabéns você estava na posição " + 5 + " e ganhou um avanço de 3 casas!");
                this.posicaoJogador += 1;
            }
            else
            {

                this.posicaoJogador -= 2;

            }

        }
    }



}