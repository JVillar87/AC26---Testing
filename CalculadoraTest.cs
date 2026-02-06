using Xunit;

public class CalculadoraTest
{
    Calculadora calculadora = new Calculadora();

[Fact]
    public void ProbandoSumar()
    {
        int resultado = Calculadora.Sumar(5, 3);
        Assert.Equal(8, resultado);
        Assert.True(resultado > 0);
        Assert.NotEqual(10, resultado); 
        Assert.IsType<int>(resultado);              
    }

[Fact]
    public void ProbandoRestar()
    {
        int resultado = calculadora.Restar(8, 3);
        Assert.Equal(5, resultado);
        Assert.True(resultado > 0);
        Assert.NotEqual(10, resultado); 
        Assert.Contains("5", resultado.ToString());         
    }

[Fact]
    public void ProbandoMultiplicar()
    {
        int resultado = calculadora.Multiplicar(15, 6);
        Assert.Equal(90, resultado);
        Assert.True(resultado > 0);
        Assert.NotEqual(10, resultado);
        Assert.Contains("9", resultado.ToString());           
    }

[Fact]
    public void ProbandoDividir()
    {
        int resultado = calculadora.Dividir(48, 8);
        Assert.Equal(6, resultado);
        Assert.True(resultado > 0);
        Assert.IsType<int>(resultado);           
    }

}