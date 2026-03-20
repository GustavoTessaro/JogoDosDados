# 🎲 Jogo de Corrida de Dados (C#)

Este projeto é um jogo simples de corrida feito em **C# no console**.\
O jogador compete contra o computador para ver quem chega primeiro na
posição **30**.

------------------------------------------------------------------------

## 📌 Objetivo do Jogo

O objetivo é avançar pelo tabuleiro jogando um dado até alcançar a
posição **30** antes do computador.

------------------------------------------------------------------------

## 🕹️ Como o Jogo Funciona

1.  O jogador e o computador começam na posição **0**.
2.  O jogador joga primeiro.
3.  Um número aleatório entre **1 e 6** é gerado.
4.  O jogador avança conforme o valor do dado.
5.  Existem casas especiais com bônus e armadilhas.
6.  Se tirar **6**, joga novamente.
7.  Depois é a vez do computador.
8.  O primeiro a chegar na posição **30** vence.

------------------------------------------------------------------------

## 📂 Estrutura do Código

### 🔹 Método `Main()`

Responsável por controlar todo o fluxo do jogo.

| Variável            | Descrição                      |
|---------------------|--------------------------------|
| posicaoJogador      | Posição atual do jogador       |
| posicaoComputador   | Posição do computador          |
| dadoJogado          | Valor sorteado no dado         |
| vezComputador       | Controla turno                 |
| jogarDenovo         | Reinício do jogo               |

------------------------------------------------------------------------

### 🔹 Método `JogarDeNovo()`

Pergunta ao jogador se deseja jogar novamente.

------------------------------------------------------------------------

## 🎯 Casas Especiais

### 🚀 Bônus (+3 casas)

-   5
-   10
-   15

### ⚠️ Armadilhas (-2 casas)

-   7
-   13
-   20

------------------------------------------------------------------------

## 🎲 Regra Especial

Se tirar **6**, joga novamente.

------------------------------------------------------------------------

## 🏆 Condição de Vitória

Quem chegar primeiro na posição **30** vence.

------------------------------------------------------------------------

## ▶️ Como Executar

    dotnet build
    dotnet run

------------------------------------------------------------------------

## 💡 Melhorias Futuras

-   Interface gráfica
-   Multiplayer
-   Mais eventos no tabuleiro
-   Sistema de pontuação
