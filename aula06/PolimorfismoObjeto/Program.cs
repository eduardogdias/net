using PolimorfismoObjeto;

//Calculadora calc = new Calculadora();

//Console.WriteLine(calc.Somar(1, 2));
//Console.WriteLine(calc.Somar(1, 2, 3));
//Console.WriteLine(calc.Somar(1.5, 2.5));

//--------------------------------------------

//Animal animal = new Animal();
//animal.EmitirSom(); 

//animal = new Cachorro();
//animal.EmitirSom();

//animal = new Gato();
//animal.EmitirSom(); 

//--------------------------------------------

// se n fosse o polimorfismo, teriamos que instanciar todos os objetos antes

Animal animal = new Animal();
int opcao;
Console.WriteLine("Digite 1 para Cachorro e 2 para Gato");
opcao = Convert.ToInt32(Console.ReadLine());

if(opcao == 1)
{
    animal = new Cachorro();
}
else if(opcao == 2)
{
    animal = new Gato();
}
animal.EmitirSom();