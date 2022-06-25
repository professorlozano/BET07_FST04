using BE7_FS4_UC9.Interfaces;

namespace BE7_FS4_UC9.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public Endereco ?endereco { get; set; }
        public float ?rendimento { get; set; }        
        

        public abstract float PagarImposto(float rendimento);
       
    }
        
}