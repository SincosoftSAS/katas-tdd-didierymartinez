using FizzBuzz;
using FluentAssertions;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorTests
    {
        [Fact]
        public void GenerarConElNumero0DebeRetornarUnaListaVacia()
        {
            var result = FizzBuzzGenerator.Generate(0);

            result.Should().BeEmpty();
        }

    }
}