using cp1_ex01;

class Program
{
    public static void Main()
    {
        FuncionarioCLT clt = new FuncionarioCLT();
        clt.Nome = "Juliano";
        clt.SalarioBase = 1500;
        clt.DescontoINSS = 20; //20%
        Console.WriteLine($"O funcionário {clt.Nome} tem um salário base de R${clt.SalarioBase}\nMas por conta de ser CLT e ter o INSS, seu salário líquido é de R${clt.CalcularSalario()}\n");


        FuncionarioPJ pj = new FuncionarioPJ();
        pj.Nome = "Abel";
        pj.SalarioBase = 3000;
        pj.TaxaImposto = 30; //30%
        Console.WriteLine($"O funcionário {pj.Nome} tem um salário base de R${pj.SalarioBase}\nMas por conta de se PJ e ter a Taxa de Imposto, seu salário líquido é de R${pj.CalcularSalario()}");

    }
}




