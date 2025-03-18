using cp1_ex02;


Circulo c = new Circulo();
c.Raio = 10;
Console.WriteLine($"Área do círculo: {Math.Round(c.CalcularArea(), 2)}");
Console.WriteLine($"Perímetro do círculo: {Math.Round(c.CalcularPerimetro(), 2)}");

Console.WriteLine("======================");

Retangulo r = new Retangulo();
r.Largura = 20;
r.Altura = 10;
Console.WriteLine($"Área do retângulo: {Math.Round(r.CalcularArea(), 2)}");
Console.WriteLine($"Perímetro do retângulo: {Math.Round(r.CalcularPerimetro(), 2)}");

Console.WriteLine("======================");

Triangulo t = new Triangulo();
t.LadoA = 10;
t.LadoB = 10;
t.LadoC = 10;
Console.WriteLine($"Área do triângulo: {Math.Round(r.CalcularArea(), 2)}");
Console.WriteLine($"Perímetro do triângulo: {Math.Round(r.CalcularPerimetro(), 2)}");


