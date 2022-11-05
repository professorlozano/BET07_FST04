using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    public class Operacoes
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round((peso / (altura * altura)), 2);
        }

        public static String ClassificarIMC(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc < 25)
                return "Peso normal";
            else if (imc < 30)
                return "Sobrepeso";
            else if (imc < 35)
                return "Obesidade Grau I";
            else if (imc < 40)
                return "Obesidade Grau II";
            else
                return "Obesidade Grau III";
        }
    }
}
