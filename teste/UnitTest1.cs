using System;
using Xunit;
using codigo.Models;


namespace TDD
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "13/09/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TesteSomar(int val1,int val2,int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Somar(val1,val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(1,2,2)]
        [InlineData(4,5,20)]
        public void TesteMultiplicar(int val1,int val2,int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(val1,val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(1,2,-1)]
        [InlineData(4,5,-1)]
        public void TesteSubtrair(int val1,int val2,int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(val1,val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }





        [Theory]
        [InlineData(15,3,5)]
        [InlineData(5,5,1)]
        public void TesteDividir(int val1,int val2,int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Dividir(val1,val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDividirPorZero()
        {
            Calculadora calc = new Calculadora();


            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(3,2);
            calc.Dividir(5,5);

            var lista = calc.VerHistorico();

            Assert.NotEmpty(lista);
            
        }
    }
}
