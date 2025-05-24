Console.Clear();

int i, tabuada, contador = 0, valMaxMult;

Console.Write("Digite o valor da tabuada: ");
bool valorTabValido = Int32.TryParse(Console.ReadLine(), out tabuada);

Console.Write("Digite até quanto esse valor será multiplicado: ");
bool valorMultValido = Int32.TryParse(Console.ReadLine(), out valMaxMult);

if (!valorTabValido || !valorMultValido || tabuada <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Número inválido");
    Console.ResetColor();
    Environment.Exit(-1);
}

for (i = tabuada; i <= tabuada * valMaxMult; i += tabuada)
{
    contador++;
    Console.WriteLine($"{contador} x {tabuada} = {i}");
}