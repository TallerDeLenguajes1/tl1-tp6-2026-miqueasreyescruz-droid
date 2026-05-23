int num = 0, aux = 0;
string s = "";

Console.WriteLine("- Ingrese el numero a invertir: ");
s = Console.ReadLine();

if (int.TryParse(s, out num))
{
    while (num > 0)
    {
        aux = aux * 10 + num % 10;
        num = num / 10;
    }
    Console.WriteLine("- El numero invertido del numero ingresado es: " + aux);
}
else
{
    Console.WriteLine("- Error: El valor ingresado no es un numero");
}