namespace projeto_paralelo
{
    public class Corrente: Conta
    {
        public double limite { get; private set; }
        
        public Corrente(string argNumero, string argAgencia, double argLimite) : base(argNumero, argAgencia)
        {
            setLimite(argLimite);
        }


        public void setLimite(double argLimite){
            if (argLimite > 100){
                this.limite = argLimite;
            }
            else
                this.limite = 0;
        }

        public override bool Sacar(double argValor)
        {
            if((argValor <= (base.saldo + this.limite)))
            {
                base.setSaldo(base.saldo - argValor);
                return true;
            }
            else{
                return false;
            }
        }

        public string ToString(){
            string texto = base.ToString();
            texto += "\nLimite: " + this.limite; 
            return texto;
        }
    }
}