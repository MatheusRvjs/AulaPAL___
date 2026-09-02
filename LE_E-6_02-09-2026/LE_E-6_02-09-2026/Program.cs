string nom, sex;
int cont = 0;

while (cont < 15)
{
    Console.WriteLine("Digite seu nome: ");
    nom = Console.ReadLine();

    Console.WriteLine("Digite sua sexualidade \n F - Feminino \n M - Masculino: ");
    sex = Console.ReadLine();

    if (sex == "M" || sex =="m")
    {
        Console.WriteLine( nom + " deve fazer um exame");
    }

    else if (sex == "F" || sex == "f")
    {
        Console.WriteLine(nom + " não precisa fazer o exame");
    }
    cont++;
}
