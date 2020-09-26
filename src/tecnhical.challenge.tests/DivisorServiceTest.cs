namespace tecnhical.challenge.tests
{
    using domain.Entidades;
    using System;
    using System.Collections.Generic;
    using technical.challenge.services;
    using Xunit;
    public class DivisorServiceTest
    {
        [Fact]
        public void DeveRetornarDivisiveisSucesso()
        {
            //Arrange
            DivisorService divisorService = new DivisorService();
            Divisor divisor = new Divisor
            {
                Numero = 10,
                Primo = false
            };
            var listaEsperada = new List<long> { 1, 2, 5, 10 };

            //Act
            var result = divisorService.CalcularDivisor(divisor);

            //Assert
            Assert.True(result.Ok);
            Assert.Null(result.Erro);
            Assert.Equal(listaEsperada, result.Divisores);
        }

        [Fact]
        public void DeveRetornarDivisiveisPrimosSucesso()
        {
            //Arrange
            DivisorService divisorService = new DivisorService();
            Divisor divisor = new Divisor(10, true);
            var listaEsperada = new List<long> { 2, 5 };

            //Act
            var result = divisorService.CalcularDivisor(divisor);

            //Assert
            Assert.True(result.Ok);
            Assert.Null(result.Erro);
            Assert.Equal(listaEsperada, result.Divisores);
        }

        [Fact]
        public void DeveRetornarErroNumeroInvalido()
        {
            //Arrange
            DivisorService divisorService = new DivisorService();
            Divisor divisor = new Divisor(0, false);
            
            //Act
            var result = divisorService.CalcularDivisor(divisor);

            //Assert
            Assert.False(result.Ok);
            Assert.Equal("Numero não pode ser nulo ou vazio.", result.Erro);
            Assert.Null(result.Divisores);
        }
    }
}
