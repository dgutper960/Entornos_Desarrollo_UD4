using System;
class ArrayExample //Nombre de la Clase 
{
    static void Main() //Método main
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };  // Variable 'letters' irá almacenando diferentes valores
        string name = ""; //Variable 'name' con valor  espacio en blanco de tipo cadena 
        int[] a = new int[10]; // Array de tipo entero
        for (int i = 0; i < letters.Length; i++) //Bucle for que nos irá cambiando el valor de 'letters' en cada ciclo
        {
            name += letters[i];
            a[i] = i + 1;  //Función que va cambiando la posición de 'i'
            SendMessage(name, a[i]); 
        }
        Console.ReadKey();
    }
    // Método para imprimir por consola la variable 'name' y 'msg' concatenada con literales
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}