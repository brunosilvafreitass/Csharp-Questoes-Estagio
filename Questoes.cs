using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharp
{
    public class Questoes
    {
        public void Questao1()
        {
            /*1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça

{

K = K + 1;

SOMA = SOMA + K;

}

imprimir(SOMA);



Ao final do processamento, qual será o valor da variável SOMA?*/

            int indice = 13, soma = 0;

            for (int k = 0; k < indice; k++)
            {
                soma += k;
            }

            Console.WriteLine($"Resultado = {soma} \n");
        }
        public void Questao2()
        {
            /*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.



IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/


            int num;
            int numAtual = 1, numAnterior = 0, fibonacci;


            Console.Write("Digite um numero sequência de Fibonacci: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numAnterior} \n{numAtual}");
            for (int i = 0; i <= num; i++)
            {
                fibonacci = numAtual + numAnterior;
                Console.WriteLine(fibonacci);
                numAnterior = numAtual;
                numAtual = fibonacci;
            }
            Console.WriteLine('\n');
        }
        public void Questao3()
        {
            Console.WriteLine("3) Descubra a lógica e complete o próximo elemento:");

            // a) 1, 3, 5, 7, ___
            Console.WriteLine("a) 1, 3, 5, 7, ___");
            int numA = -1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numA += 2);
            }
            Console.WriteLine('\n');

            // b) 2, 4, 8, 16, 32, 64, ____
            Console.WriteLine("b) 2, 4, 8, 16, 32, 64, ____");
            int numB = 1;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(numB *= 2);
            }
            Console.WriteLine('\n');

            // c) 0, 1, 4, 9, 16, 25, 36, ____
            Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, ____");
            for (int i = 0; i < 8; i++)
            {

                Console.WriteLine($"{i * i}");
            }
            Console.WriteLine('\n');

            // d) 4, 16, 36, 64, ____
            Console.WriteLine("d) 4, 16, 36, 64, ____");
            for (int i = 2; i <= 10; i += 2)
            {

                Console.WriteLine($"{i * i}");
            }
            Console.WriteLine('\n');

            // e) 1, 1, 2, 3, 5, 8, ____
            Console.WriteLine("e) 1, 1, 2, 3, 5, 8, ____");
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            Console.WriteLine(numeroAtual);
            for (int i = 0; i < 6; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }
            Console.WriteLine('\n');
            // f) 2,10, 12, 16, 17, 18, 19, ____
            Console.WriteLine("f) 2,10, 12, 16, 17, 18, 19, ____");
            //Resposta:  
            Console.WriteLine("O próximo número será 200, todos que começam com a letra D, não consegui fazer em código.");

            Console.WriteLine('\n');


        }
        public void Questao4()
        {
            /*4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

            Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?*/

            //Resposta: 

            Console.WriteLine("Ligo um interruptor e vou verificar a qual sala ele está conectado. Ao retornar à sala com os três interruptores, identifico o segundo e, consequentemente, descubro o terceiro.");
            Console.WriteLine('\n');
        }
        public void Questao5()
        {
            /* 5) Escreva um programa que inverta os caracteres de um string.

             IMPORTANTE:

             a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

             b) Evite usar funções prontas, como, por exemplo, reverse;*/

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Bruno");
            pilha.Push("Silva");

            foreach (string item in pilha)
            {
                Console.WriteLine(new Stack<char>(item).ToArray());
            }
        }
    }
}