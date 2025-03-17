using ConsoleApp1;


/*
//entradas
Console.WriteLine("Digite o primeiro numero: ");
calculadora.n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
calculadora.n2 = Convert.ToDouble(Console.ReadLine());
*/


Console.WriteLine("Digite o primeiro numero: ");
double v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
double v2 = Convert.ToDouble(Console.ReadLine());


//usando construtor
Calculadora calculadora = new Calculadora(v1, v2);


//soma
calculadora.Somar();
Console.WriteLine($"Soma: {calculadora.res}");

//subtração
Console.WriteLine($"Subtração: {calculadora.Subtrair()}");

//multiplicação
//double v1 = calculadora.n1;
//double v2 = calculadora.n2;

calculadora.Multiplicar(v1, v2);
Console.WriteLine($"Multiplicação: {calculadora.res}");

//divisão

Console.WriteLine($"Divisão: {calculadora.Dividir(v1, v2)}");

