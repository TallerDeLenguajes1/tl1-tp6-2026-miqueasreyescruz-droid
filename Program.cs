// int num = 0, aux = 0;
// string s = "";

// Console.WriteLine("- Ingrese el numero a invertir: ");
// s = Console.ReadLine();

// if (int.TryParse(s, out num))
// {
//     while (num > 0)
//     {
//         aux = aux * 10 + num % 10;
//         num = num / 10;
//     }
//     Console.WriteLine("- El numero invertido del numero ingresado es: " + aux);
// }
// else
// {
//     Console.WriteLine("- Error: El valor ingresado no es un numero");
// }

string cadena1, cadena2;

Console.WriteLine("Ingrese una cadena de texto: ");
cadena1 = Console.ReadLine();

Console.WriteLine($"Longitud de la cadena ingresada: {cadena1.Length}");

Console.WriteLine("Ingrese una segunda cadena de texto: ");
cadena2 = Console.ReadLine();

Console.WriteLine($"Resultado de la concatenacion de ambas cadenas: {cadena1}{cadena2}");

Console.WriteLine($"Subcadena extraida: {cadena1.Substring(0, (cadena1.Length / 2))}");

Console.WriteLine("Descomposicion de la cadeana 1:");
foreach (char letra in cadena1)
{
    Console.WriteLine($"{letra}");
}