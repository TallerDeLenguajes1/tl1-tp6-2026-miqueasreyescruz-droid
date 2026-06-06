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

Console.WriteLine("La primera cadena ingresada contiene la letra \"a\"?");
if (cadena1.IndexOf("a") != -1)
{
    Console.WriteLine("La cadena, contiene la letra \"a\"");
}
else
{
    Console.WriteLine("La cadena, no contiene la letra \"a\"");
}

Console.WriteLine("Convirtiendo cadena en solo MAYUSC:");
cadena1 = cadena1.ToUpper();
Console.WriteLine(cadena1);
Console.WriteLine("Convirtiendo cadena en solo MINUSC:");
cadena1 = cadena1.ToLower();
Console.WriteLine(cadena1);

Console.WriteLine("Separando palabras de la cadena ingresada: ");
string[] palabras = cadena1.Split(" "); 
foreach (string palabra in palabras)
{
    Console.WriteLine($"-{palabra}");
}