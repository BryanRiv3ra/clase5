static int main2()
{
    int num, max = int.MinValue, min = int.MaxValue
    do
    {
        Console.WriteLine("ingrese su numero");
        num = Convert.ToInt32(Console.ReadLine());

        if (num != 0)
        {
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }
    }
}
while (num != 0);

Console.WriteLine("El número máximo es: " + max);
Console.WriteLine("El número mínimo es: " + min);
static void Main()
{
    Console.WriteLine("Piense en un numero.");
    Console.WriteLine("Sigue las instrucciones y te diré en qué número estás pensando.");

    Console.Write("Ingresa un número: ");
    string numeroString = Console.ReadLine();

    int resultado = Convert.ToInt32(numeroString) * 2;
    resultado += 8;
    resultado *= 5;

    Console.WriteLine("Tu resultado e: " + resultado);
    Console.WriteLine("Dimer tu resultado .");

    Console.Write("Resultado: ");
    int resultadoUsuario = Convert.ToInt32(Console.ReadLine());

    string resultadoUsuarioString = resultadoUsuario.ToString();

    string resultadoAnuladoString = resultadoUsuarioString.Substring(0, resultadoUsuarioString.Length - 1);

    int resultadoAnulado = Convert.ToInt32(resultadoAnuladoString);


    resultadoAnulado -= 4;

    Console.WriteLine("El número en el que estás pensando es: " + resultadoAnulado);
}
Main();