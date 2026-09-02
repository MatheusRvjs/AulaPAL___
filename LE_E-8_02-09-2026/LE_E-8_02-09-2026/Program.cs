int cont = 0, resto;

while (cont <= 750)
{
    resto = cont % 4;

    if (resto == 0)
    {
        Console.WriteLine( cont + " é multiplo de quatro \n ");
    }

    else
    {
        Console.WriteLine("Não existe numero multiplo de quatro para: " +cont+ "\n");
    }

    cont++;

}
