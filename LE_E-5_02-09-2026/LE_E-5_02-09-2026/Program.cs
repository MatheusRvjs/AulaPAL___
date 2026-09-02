string nom;
int cont = 0, anonasc, anoatu, idade;

while (cont < 4)
{
    Console.WriteLine("Digite seu nome; ");
    nom = Console.ReadLine();

    Console.WriteLine("Digite seu ano de nascimento: ");
    anonasc = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o ano em que estamos: ");
    anoatu = int.Parse(Console.ReadLine());

    idade = anoatu - anonasc;

    Console.WriteLine( nom + " Tem " + idade + " Anos de idade ");
    cont++;
}