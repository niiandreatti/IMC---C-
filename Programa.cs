﻿using System;

namespace IMCApp
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa IMC!");

            Console.Write("Por favor, insira sua altura (em metros ou centímetros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            if (altura > 3) 
            {
                altura /= 100;
            }
            
            Console.Write("Por favor, insira seu peso (em quilogramas): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Calculo calculo = new Calculo();
            double imc = calculo.CalcularIMC(altura, peso);
            string classificacao = calculo.MensagemIMC(imc);

            Console.WriteLine($"Seu IMC é: {imc:F2}");
            Console.WriteLine($"Classificação: {classificacao}");
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
