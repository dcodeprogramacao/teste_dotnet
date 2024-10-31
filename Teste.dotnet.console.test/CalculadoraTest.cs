using Teste.dotnet.console;

namespace Teste.dotnet.console.test;

public class CalculadoraTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DivisaoReal()
    {
        var calculadora = new Calculadora();
        var result = calculadora.Dividir(50, 10);

        Assert.That(result, Is.EqualTo(5), "50 dividido por 10 seria 5");
    }
}