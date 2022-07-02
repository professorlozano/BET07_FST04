namespace projeto_paralelo
{
    public abstract class Conta
    {
        public string? numero {  get; private set; }
        
        public string? agencia { get; private set; }

        public double saldo {get; private set;}

        public Conta(string argNumero, string argAgencia){
            setNumero(argNumero);
            setAgencia(argAgencia);
            setSaldo(0);
        }

        public void setNumero(string argNumero){
            if (argNumero.Length > 4){
                this.numero = argNumero;
            }
        }

        public void setAgencia(string argAgencia){
            if(argAgencia.Length > 2){
                this.agencia = argAgencia;
            }
        }

        public void setSaldo(double argSaldo){
            this.saldo = argSaldo; 
        }

        public abstract bool Sacar(double argValor);

        public bool Depositar(double argValor)
        {
            if (argValor > 0){
                this.saldo = this.saldo + argValor;
                return true;
            }
            else{
                return false;
            }   
        }

        public string ToString(){
            string texto = "Agencia: " + this.agencia +
                           "\nNro. Conta: " + this.numero +
                           "\nSaldo: "+ this.saldo;
            return texto;
        }

        //Depositar(100);

        /*
        métodos
        possuem o modificador de visibilidade (public, private, protected...)
        retorno (bool, string, int, double, float, objeto de uma classe, lista, void...)
        nome do método (padrão não é regra, mas é bom seguir...iniciais miusculas e denotam ação...
        exemplo verbos no infinitivo...Depositar, Sacar, Imprimir, Verificar, Calcular...etc)
        argumentos (são os valores, que podem existir ou não, para que um método funcione. Chamamos de assinatura do método)

        */
        
    }
}