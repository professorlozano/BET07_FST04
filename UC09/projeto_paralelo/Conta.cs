namespace projeto_paralelo
{
    public class Conta
    {
        public string? numero {  get; private set; }
        
        public string? agencia { get; private set; }

        private double saldo;

        public Conta(string argNumero, string argAgencia){
            //this.numero = argNumero;
            setNumero(argNumero);
            //this.agencia = argAgencia;
            setAgencia(argAgencia);
            setSaldo(0);
        }

      

        
        public void setNumero(string numero){
            if (numero.Length > 4){
                this.numero = numero;
            }
        }

        public void setAgencia(string agencia){
            if(agencia.Length > 2){
                this.agencia = agencia;
            }
        }

        public void setSaldo(double saldo){
            this.saldo = saldo; 
        }

        public double getSaldo(){
            return this.saldo;
        }
        
    }
}