using TestarIMC;
using TesteIMC;
using Xunit;

namespace TesteIMCXunit
{
    public class ClassificarIMCTests
    {
        //método de teste
        [Fact]
        //descricao do teste
        public void ClassificarIMC_RetornaResultado()
        {
            //arrange
            double imc = 28;
            //act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);
            //assert
            Assert.Equal("Sobrepeso", classificacaoIMC);
        }

        [Theory]
        [InlineData(28,"Sobrepeso")]
        [InlineData(31,"Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, string resultadoEsperado)
        {
            var resultadoDoIMC = Operacoes.ClassificarIMC(primeiroNumero);
            Assert.Equal(resultadoEsperado, resultadoDoIMC);
        }
    }
}
