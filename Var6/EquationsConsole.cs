namespace Var6;

//Класс для работы с объектом класса Equations через консоль
public static class EquationsConsole
{
    //Метод для ввода данных из консоли
    public static Equations enterDigit()
    {
        Console.WriteLine("Приветствуем вас в программе для решения уравнений!");
        Console.Write("Введите переменную x: ");
        double x;
        //Проверка на то, что введенное из консоли значение можно привести к типу double
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Вы ввели не число, попробуйте ещё");
        }

        return new Equations(x);
    }

    //Метод вывода в консоль результата решения уравнения
    public static void showResult(Equations equation)
    {
        Console.WriteLine($"Результат вычисления: {equation.equationsCalc()}");
    }
}