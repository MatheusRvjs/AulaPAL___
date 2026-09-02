int num = 0, valln, soma = 0;
while (num < 5)
{
    Console.WriteLine("Digite um numero");
    valln = int.Parse(Console.ReadLine());
    soma = soma + valln;
    num++;

    Console.WriteLine("Esse é o valor da soma: " + soma);

}