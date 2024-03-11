using System;

static void Maximo()
{
    int num, max = int.MinValue, min = int.MaxValue;
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

    while (num != 0);


    Console.WriteLine("El número máximo es: " + max);
    Console.WriteLine("El número mínimo es: " + min);
}
static void juego()
{
    Console.WriteLine("Piensa en un numero para empezar el juego.");
    Thread.Sleep(5000);

    Console.WriteLine("Sigue los pasos y adivinare tu numero pensado.");
    Thread.Sleep(5000);

    Console.WriteLine("Tu numero multiplicalo por 2. ");
    Thread.Sleep(5000);

    Console.WriteLine("Tu numero multiplicalo por 5. ");
    Thread.Sleep(5000);

    Console.WriteLine("ahora sumale 8.");
    Thread.Sleep(5000);

    Console.WriteLine("ahora escribe tu resultado.");
    Thread.Sleep(5000);

    int numero = (Convert.ToInt32(Console.ReadLine()));
    string numeroLetra = numero.ToString();
    string resultado = numeroLetra.Substring(0, numeroLetra.Length - 1);
    Console.WriteLine("Tu numero es :  " + resultado);
}
Maximo();
juego();