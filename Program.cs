// Exercício do site URI "Soma impares consecutivos"


int Troca, Soma;
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

Soma = 0;

if (X > Y)
{
    Troca = X;
    X = Y;
    Y = Troca;
}
for (int i = X + 1; i < Y; i++)
{
    if (i % 2 != 0)
    {
        Soma = Soma + i;
    }
}
Console.WriteLine(Soma);
