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
        
    }
}