using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

  
namespace Aula_04_07_Xunit
{
     public class Calculadora_test
        {
            [Fact]
            public void TesteSomar()
            {
                double resultadoSom = Calculadora.Somar(2, 3);

                Assert.Equal(5, resultadoSom);
            }

            [Fact]
            public void TesteSubtrair()
            {
                double resultadosub = Calculadora.Subtrair(10, 3);

                Assert.Equal(7, resultadosub);
            }

            [Fact]
            public void TesteMultiplicar()
            {
                double resultadomult = Calculadora.Multiplicar(9, 2);

                Assert.Equal(18, resultadomult);
            }

            [Fact]
            public void TesteDividir()
            {
                double resultadodiv = Calculadora.Dividir(6, 3);

                Assert.Equal(2, resultadodiv);
            }
            [Fact]
            public void TesteDivInfinito()
            {
                double resultadodivinf = Calculadora.Dividir(6, 0);

                Assert.Equal(double.PositiveInfinity, resultadodivinf);
            }

     }

}


