//Arreglos
//Crea una matriz para contener los valores enteros 0 a 9​
int[] numerosEnteros = new int[10];
for (int i = 0; i < numerosEnteros.Length; i++)
{
    numerosEnteros[i] = i;
    Console.WriteLine(numerosEnteros[i]);
}
Console.WriteLine("----------");
//Crea una matriz con los nombres "Tim", "Martin", "Nikki" y "Sara".​
string[] nombres = new string[4] { "Tim", "Martin", "Nikki", "Sara" };

for (int j = 0; j < nombres.Length; j++)
{
    Console.WriteLine(nombres[j]);
}
Console.WriteLine("----------");
//Crea una matriz de longitud 10 que alterne entre valores verdadero y falso, empezando por verdadero.​
bool[] BoolMatriz = new bool[10] { true, false, true, false, true, false, true, false, true, false };
for (int k = 0; k < BoolMatriz.Length; k++)
{
    Console.WriteLine(BoolMatriz[k]);
}
Console.WriteLine("----------");
//Listas 
/*
Crea una lista de sabores de helados que contenga al menos 5 sabores diferentes (¡no dudes en añadir más de 5!).​
Imprime la longitud de esta lista después de construirla. ​
Imprime el tercer sabor de la lista y luego elimina ese valor. ​
Obtén la nueva longitud de la lista (¡sólo debería ser una menos!)​
*/
List<String> SaboresHelados = new List<string>();
SaboresHelados.Add("Vainilla");
SaboresHelados.Add("Chocolate");
SaboresHelados.Add("Menta-Chocolate");
SaboresHelados.Add("Piña");
SaboresHelados.Add("Frutilla");
SaboresHelados.Add("Limon");
Console.WriteLine(SaboresHelados.Count);
Console.WriteLine(SaboresHelados[2]);
SaboresHelados.Remove(SaboresHelados[2]);
Console.WriteLine(SaboresHelados.Count);
for (int h = 0; h < SaboresHelados.Count; h++)
{
    Console.WriteLine(SaboresHelados[h]);
}
Console.WriteLine("----------");

//Diccionario
/*
Crea un diccionario que almacene tanto claves de cadena como valores de cadena. ​
Añade pares clave/valor a este diccionario donde:​
cada clave sea un nombre de la matriz de nombres​
cada valor sea un sabor seleccionado al azar de tu lista de sabores.​
Revisa el diccionario e imprime el nombre de cada usuario y su sabor de helado asociado.​
*/
Dictionary<string, string> DiccionarioHelados = new Dictionary<string, string>();
Random rand = new Random();
DiccionarioHelados.Add("Nombre", nombres[rand.Next(0,5)]);
DiccionarioHelados.Add("Helado", SaboresHelados[rand.Next(0,6)]);
foreach (var element in DiccionarioHelados)
{
    Console.WriteLine(element.Key + " - " + element.Value);
}