using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstudoVetorCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa para ler um numero positivo N, depois ler N numeros quaisquer, e armazenalos em um vetor.
            // em seguida mostrar na tela todos os numeros do vetor!

            int N;  //1- declarou o tipo de variável! 
            double[] vet;  //criou o vetor vet dizendo q o tipo vai ser double;

            N = int.Parse(Console.ReadLine()); //2- usar comadno parse para da entrada com console.readline();
            vet = new double[N]; //4- declarou q o vetor vet vai ter N indices. tem q colocar a instanciação depois de ler a variavel N pq se não ad errro!!!
            for (int i = 0; i < N; i++) //3- criou a estrutura for para dizer q, vetor começa no zero e i tem q ser menor do q N e depois inclementar ++;
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //5- dentro do for, indica q vet rebe o i, pois vai ser o valor que vamos digitar para entrada, e para aceitar o virgula com separação decimal, colocamos a using system globalization e o comanto cultureinfo.invariante culture.
            }
            for (int i = 0; i < N; i++) //5- declara outro for para ler os numero na tela imprimir!
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture)); //6- aqui pede pra ler com comando e F1 para uma casda decimal na virgula.
            }
            

            Console.ReadLine();
        }
    }
}
