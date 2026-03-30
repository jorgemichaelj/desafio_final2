using System;

class Program
{
    static void Main()
    {
        // 1. poção tamanhop
        string[] pocoes = { "Cura", "Mana" };
        int tamanho = pocoes.Length;

        if (tamanho > 0)
        {
            Console.WriteLine("Poção consumida!");
        }
        else
        {
            Console.WriteLine("Inventário Vazio!");
        }



        // verifica a prota vip
        int nivelJogador = 55;

        if (nivelJogador >= 50)
        {
            Console.WriteLine("Porta VIP liberada!");
        }
        else
        {
            Console.WriteLine("Vá para treinamento!");
        }



        // ve o bglho de teste de cada lado
        int noAtual = 50;
        int valorProcurado = 85;


        if (valorProcurado > noAtual)
        {
            Console.WriteLine("Ir para DIREITA");
        }
        else if (valorProcurado < noAtual)
        {
            Console.WriteLine("Ir para ESQUERDA");
        }
        else
        {
            Console.WriteLine("Valor encontrado!");
        }
    }
}



