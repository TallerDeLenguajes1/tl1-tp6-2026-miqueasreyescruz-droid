using System;

int selector, num1, num2, result;
bool verificador = true;


Console.WriteLine("--- CalculadoraV1 ---");
do
{
    Console.WriteLine("------ MENU ------");
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MILTIPLICACION");
    Console.WriteLine("4. DIVISION");
    Console.WriteLine("5. SALIR");
    Console.WriteLine("------------------");

    do
    {
        selector = Console.Read();
        if (selector < 1 || selector > 5)
        {
            Console.WriteLine("-> ERROR: opcion no valida, ingrese nuevamente:");
        }
    } while(selector < 1 || selector > 5);

    Console.WriteLine("-> Ingrese el primer numero: ");
    num1 = Console.Read();

    Console.WriteLine("-> Ingrese el segundo numero: ");
    num2 = Console.Read();

    switch (selector)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + result);
            break;
        case 2:
            result = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + result);
            break;
        case 3:
            result = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + result);
            break;
        case 4:
            if(num2 != 0)
            {
                result = num1 / num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);   
            }
            else
            {
                Console.Write("ERROR: no se puede divir en 0");
            }
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("ERROR: valor no esperado");
            break;
    }

    do
    {
        Console.WriteLine("-> Desea realizar otra operacion? (1. SI / 2. NO)");
        selector = Console.Read();
    } while (selector < 1 || selector > 2);

    if (selector == 2)
    {
        verificador = false;
        Console.WriteLine("Saliendo...");
    }

} while (verificador);