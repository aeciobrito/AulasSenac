using System;
using Xunit;
using Exercicio0101_ContagemDeTexto;

namespace Exercicio0101_Test
{
    public class ProgramTest
    {       
        [Fact]
        public void ContadorDeLetras_DeveTotalizarApenasAsLetras()
        {
            var result = Program.ContadorDeLetras("text 123/*");
            Assert.Equal(4, result);
        }

        [Fact]
        public void ContadorDeNumeros_DeveTotalizarApenasOsNumeros()
        {
            var result = Program.ContadorDeNumeros("text 123/*");
            Assert.Equal(3, result);
        }

        [Fact]
        public void ContadorDeSeparadores_DeveTotalizarApenasSeparadores()
        {
            var result = Program.ContadorDeSeparadores("text 123/*");
            Assert.Equal(1, result);
        }

        [Fact]
        public void CorretorDeTexto_DeveRetornarOTextoCorrigido()
        {
            var result = Program.CorretorDeTexto("35041");
            Assert.Equal("ESOAI", result);
        }
    }
}
