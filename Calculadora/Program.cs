using System.Diagnostics;

double num1, num2, op, resultado;

Console.WriteLine("Bem vindo a calculadora");
Console.WriteLine("\n Lista de operações:\n   1 - Soma\n   2 - Subtração\n   3 - Divisão\n    4 - " +
    "Multiplicação\n    5 - Potenciação\n   6 - Radiciação\n\nEscolha a operação:");
op = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o primeiro numero:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o segundo numero:");
num2 = Convert.ToInt32(Console.ReadLine());

resultado = 1;
if(op == 1)
{
    resultado = num1 + num2;
   Console.WriteLine("o resultado é "+ resultado);
}
else if(op == 2)
{
    if(num1 > num2)
    {
        resultado = num1 - num2;
    }
    else{
        resultado = num2 - num1;
    }
    Console.WriteLine("o resultado é " + resultado);
}
else if(op == 3)
{
    resultado = num1 / num2;
    Console.WriteLine("o resultado é " + resultado);
}
else if(op == 4)
{
    resultado = num1 * num2;
    Console.WriteLine("o resultado é " + resultado);
}
else if(op == 5)
{
    resultado = num1;
    pot();
}
else if(op == 6)
{
    resultado = num1;
    resultado = Math.Pow(num1, 1 / num2);
}

void pot()
{
    if (num2 != 0)
    {
        for (int i = 0; i < num2; i++)
        {
            resultado *= num1;
        }
    }
}

Console.WriteLine($"O resultado é {resultado}");