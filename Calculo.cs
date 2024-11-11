using System;

namespace IMCApp
{
    public class Calculo
    {
        public double CalcularIMC(double altura, double peso)
        {
            return peso / Math.Pow(altura, 2);
        }

        public string MensagemIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                return "Obesidade grau I";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III";
            }
        }
    }
}
