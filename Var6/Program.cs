using Var6;

string stopOrRerun = "run";
while (stopOrRerun == "run")
{
    Equations equation = EquationsConsole.enterDigit();
    EquationsConsole.showResult(equation);
    Console.Write("Введите run для продолжения или stop для выхода из программы: ");
    stopOrRerun = Console.ReadLine();
}


