class Computador
{
    public int posicaoComputador { get; set; }
    public int dadoJogado { get; set; }
    public Random random = new Random();
    public Computador(int posicaoComputadorP)
    {
        posicaoComputador = posicaoComputadorP;
        dadoJogado = 0;
    }

    public void computadorJoga(int posicaoJogador)
    {
        Console.WriteLine("\nPosição Jogador: " + posicaoJogador);
        Console.WriteLine("Posição Computador: " + this.posicaoComputador);
        Console.Write("\nAperte qualquer tecla para o Computador jogar!");
        Console.ReadKey();
        Console.Clear();
        dadoJogado = random.Next(1, 7);
        this.posicaoComputador += dadoJogado;
        Console.WriteLine("O computador avançou " + dadoJogado + " casas e está na posição " + this.posicaoComputador);
    }

    public void verificaArmadilhas()
    {

        if (this.posicaoComputador == 5 || this.posicaoComputador == 10 || this.posicaoComputador == 15)
        {
            Console.WriteLine("\nQue pena! o computador estava na posição " + this.posicaoComputador + " e ganhou um avanço de 3 casas!");
            this.posicaoComputador += 3;
        }

        if (this.posicaoComputador == 7 || this.posicaoComputador == 13 || this.posicaoComputador == 20)
        {
            Console.WriteLine("\nQue sorte! o computador caiu numa armadilha! Computador estava na posição " + this.posicaoComputador + " e recuou 2 casas!");

            if (this.posicaoComputador == 7)
            {
                Console.WriteLine("\nQue pena! o computador estava na posição " + 5 + " e ganhou um avanço de 3 casas!");
                this.posicaoComputador += 1;
            }
            else
            {

                this.posicaoComputador -= 2;

            }

        }

    }

}