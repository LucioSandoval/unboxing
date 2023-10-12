// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* Crea una aplicación de consola y sigue las siguientes instrucciones 
para descomprimir de forma segura una matriz de Objetos. ​ */

/* Create an empty List of type object

Add the following values to the list: 7, 28, -1, true, "chair" 

Loop through the list and print all values

Add all values that are Int type together and output the sum*/

List<object> listaObjetos = new List<object>();
listaObjetos.Add(7);
listaObjetos.Add(28);
listaObjetos.Add(-1);
listaObjetos.Add(true);
listaObjetos.Add("chair");

Console.WriteLine("Lista con items agregado");
foreach (object item in listaObjetos)
{
    Console.WriteLine(item);
}
Console.WriteLine(" ------ Suma de números ---------");
int suma =0;
foreach (object item in listaObjetos)
{
    if(item is int){
        suma += (int)item;
    }
}
Console.WriteLine("la suma de números  de la lista es: "+ suma);
