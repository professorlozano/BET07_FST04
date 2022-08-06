namespace projeto_imc
{
    public class Pessoa
    {
        public double peso { get; set; }
        public double altura { get; set; }
        public double imc { get; set; }

        public Pessoa(double argPeso, double argAltura){
            this.peso = argPeso;
            this.altura = argAltura;
            this.imc = calcularIMC(this.peso, this.altura);
        }

        public double calcularIMC(double argPeso, double argAltura){
            double resultado = argPeso / (argAltura * argAltura);
            return resultado;
        }

        public string classificarIMC(double argIMC){
            string classificacao;

            if(argIMC < 18.5){
                classificacao = "abaixo do peso";
            }
            else if(argIMC >= 18.5 && argIMC < 25){
                classificacao = "peso normal";
            }
            else if (argIMC >= 25 && argIMC < 30){
                classificacao = "sobrepeso";
            }
            else if (argIMC >= 30 && argIMC < 35){
                classificacao = "obesidade I";
            }
            else if (argIMC >= 35 && argIMC < 40){
                classificacao = "obesidade II";
            }
            else{
                classificacao = "obesidade III";
            }
            return classificacao;
        }
    }
}


           /*
            tabela verdade do E (&&)
            V && V = V
            V && F = F
            F && V = F
            F && F = F
            Na tabela verdade do E, terei resultado verdadeiro apenas qdo as duas proposicoes forem verdadeiras.

            tabela verdade do OU (||)
            V || V = V
            V || F = V
            F || V = V
            F || F = F
            Na tabela verdade do OU, terei resultado falso apenas qdo as duas proposicoes forem falsas.
            */