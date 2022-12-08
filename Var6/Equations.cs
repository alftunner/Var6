namespace Var6;

//Класс для уравнений
public class Equations
{
    //вводим свойство для переменной x
    private double x;

    //конструктор класса для инициализации свойства x
    public Equations(double x)
    {
        this.x = x;
    }

    //метод для вычисления уравнения
    public double equationsCalc()
    {
        return x - Math.Pow(2, x) + -Math.Exp(x) / (Math.Pow(x, 6) + 4);
    }
}