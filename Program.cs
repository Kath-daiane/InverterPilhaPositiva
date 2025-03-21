using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando a pilha
        Stack<int> pilha = new Stack<int>();

        // Passo 1: Inserir 5 números inteiros na pilha
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            pilha.Push(numero); // Inserindo o número na pilha
        }

        // Passo 2: Remover os números negativos
        Stack<int> pilhaFiltrada = new Stack<int>();

        while (pilha.Count > 0)
        {
            int numero = pilha.Pop(); // Retira o número do topo da pilha
            if (numero >= 0)
            {
                pilhaFiltrada.Push(numero); // Adiciona na pilha filtrada se for positivo
            }
        }

        // Passo 3: Inverter a ordem dos números
        Stack<int> pilhaInvertida = new Stack<int>();

        while (pilhaFiltrada.Count > 0)
        {
            pilhaInvertida.Push(pilhaFiltrada.Pop()); // Inverte a ordem
        }

        // Exibe os números invertidos
        Console.WriteLine("\nNúmeros invertidos e sem negativos:");
        while (pilhaInvertida.Count > 0)
        {
            Console.WriteLine(pilhaInvertida.Pop());
        }
    }
}
