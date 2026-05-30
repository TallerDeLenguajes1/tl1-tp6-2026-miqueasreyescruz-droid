using System;

float num1 = 0, num2 = 0, result = 0;
string selector = "";
bool verificador = true;


Console.WriteLine("--- CalculadoraV1 ---");
do
{
    Console.WriteLine("------ MENU ------");
    Console.WriteLine("1. SUMA");
    Console.WriteLine("2. RESTA");
    Console.WriteLine("3. MILTIPLICACION");
    Console.WriteLine("4. DIVISION");
    Console.WriteLine("------------------");

    selector = Console.ReadLine();
    if (selector != "1" && selector != "2" && selector != "3" && selector != "4")
    {
        Console.WriteLine("-> ERROR: opcion no valida, ingrese nuevamente:");
    }
    else
    {
        bool validarNum1 = false, validarNum2 = false;
        string aux = "";

        while(!validarNum1)
        {
            Console.WriteLine("-> Ingrese el primer numero: ");
            aux = Console.ReadLine();
            validarNum1 = float.TryParse(aux, out num1);
            if (!validarNum1) Console.WriteLine("ERROR: valor invalido ingresado");
        }

        while(!validarNum2)
        {
            Console.WriteLine("-> Ingrese el segundo numero: ");
            aux = Console.ReadLine();
            validarNum2 = float.TryParse(aux, out num2);
            if (!validarNum2) Console.WriteLine("ERROR: valor invalido ingresado");
        }

        switch (selector)
        {
            case "1":
                result = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                break;
            case "2":
                result = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                break;
            case "3":
                result = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                break;
            case "4":
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
            default:
                Console.WriteLine("ERROR: valor no esperado");
                break;
        }
    }

    Console.WriteLine("------------------");

    do
    {
        Console.WriteLine("-> Desea realizar otra operacion? (S/N)");
        selector = Console.ReadLine().ToUpper();
    } while (selector != "S" && selector != "N");

    if (selector == "N")
    {
        verificador = false;
        Console.WriteLine("Saliendo...");
    }
} while (verificador);