string respos; 
int cont = 1, pont = 0; 
while (cont < 30)

{

    Console.WriteLine("digite a resposta da primeira questão:\nA, B, C ou D ");

    respos = Console.ReadLine();

    switch (respos.ToLower())

    {

        case "a":

            pont++;

            break;

        default:

            break;

    }

    Console.WriteLine("digite a resposta da segunda questão:\nA, B, C ou D ");

    respos = Console.ReadLine();

    switch (respos.ToLower())

    {

        case "c":

            pont++;

            break;

        default:

            break;

    }

    Console.WriteLine("digite a resposta da terceira questão:\nA, B, C ou D ");

    respos = Console.ReadLine();

    switch (respos.ToLower())

    {

        case "d":

            pont++;

            break;

        default:

            break;

    }

    cont++;

}
Console.WriteLine("a pontuação total de todos foi de " + pont);