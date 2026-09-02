int cont = 0, resto, num;

while (cont < 20)
{
    Console.WriteLine("Digite um numero: ");
    num = int.Parse(Console.ReadLine());

    resto = num % 3;

    if (resto == 0)
    {
        Console.WriteLine( num + " é multiplo de três");
    }

    else
    {
        Console.WriteLine("Não existe numero multiplo de tres para: " + num);
    }

    cont++;

}