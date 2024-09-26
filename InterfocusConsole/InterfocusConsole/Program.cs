// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 10;
var z = x;
z += 1;

Console.WriteLine("X:{0} Z:{1}" , x , z);

if ( z % 2 == 0 )
{
    Console.WriteLine(" Z é par");
}
else
{
    Console.WriteLine("Z é impar");
}

var y = "texto";
bool b = true;
double d = 1.75;


var lista = new List<string>();
lista.Add("Item 1");
lista.Add("Item 2");

var lista2 = lista;

lista2.Add("Item 3");

Console.WriteLine($"Lista 1: {lista.Count} itens");
Console.WriteLine($"Lista 2: {lista2.Count} itens");

var soma = x + z;
var maiorQueDez = soma > 10;
var impar = soma % 2 == 1;

var combinação = maiorQueDez && impar; // maiorQueDez and impar

while (z < 15)
{
    Console.WriteLine("Z: {0}", z);
    z++;
}

var v = 0;

do
{
    var v = Console.ReadLine();
    ReadOnlySpan<byte> texto = default;
    v = int.Parse(texto);
} while (v % 2 == 0);

Console.WriteLine("Digitou: " + v);

for ( var i = 0; i < 10; i++ )
{
    Console.WriteLine("{0}", i);
}