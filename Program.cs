using System;

double num1 = 0, num2 = 0, num3 = 0, result = 0;
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
    Console.WriteLine("5. ANALIZAR");
    Console.WriteLine("------------------");

    do
    {
        selector = Console.ReadLine();
        if (selector != "1" && selector != "2" && selector != "3" && selector != "4" && selector != "5")
        {
            Console.WriteLine("-> ERROR: opcion no valida, ingrese nuevamente:");
        }
    } while (selector != "1" && selector != "2" && selector != "3" && selector != "4" && selector != "5");
    
    bool validarNum1 = false, validarNum2 = false, validarNum3 = false;

    if (selector != "5")
    {
        while(!validarNum1)
        {
            Console.WriteLine("-> Ingrese el primer numero: ");
            validarNum1 = double.TryParse(Console.ReadLine(), out num1);
            if (!validarNum1) Console.WriteLine("ERROR: valor invalido ingresado");
        }

        while(!validarNum2)
        {
            Console.WriteLine("-> Ingrese el segundo numero: ");
            validarNum2 = double.TryParse(Console.ReadLine(), out num2);
            if (!validarNum2) Console.WriteLine("ERROR: valor invalido ingresado");
        }
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
                Console.WriteLine("ERROR: no se puede divir en 0");
            }
            break;
        case "5":
            while(!validarNum3)
            {
                Console.WriteLine("-> Ingrese el numero a analizar: ");
                validarNum3 = double.TryParse(Console.ReadLine(), out num3);
                if (!validarNum3) Console.WriteLine("ERROR: valor invalido ingresado");
            }

            Console.WriteLine("-> Analizando el numero " + num3 + ":");
            Console.WriteLine("Valor Absoluto: " + valorAbs(num3));
            Console.WriteLine("Cuadrado: " + cuadrado(num3));
            Console.WriteLine("Razi cuadrada: " + raizCuadrada(num3));
            Console.WriteLine("Seno: " + seno(num3));
            Console.WriteLine("Coseno: " + coseno(num3));
            Console.WriteLine("------------------");
            
            Console.WriteLine("COMPARANDO NUMEROS");
            while(!validarNum1)
            {
                Console.WriteLine("-> Ingrese el primer numero: ");
                validarNum1 = double.TryParse(Console.ReadLine(), out num1);
                if (!validarNum1) Console.WriteLine("ERROR: valor invalido ingresado");
            }

            while(!validarNum2)
            {
                Console.WriteLine("-> Ingrese el segundo numero: ");
                validarNum2 = double.TryParse(Console.ReadLine(), out num2);
                if (!validarNum2) Console.WriteLine("ERROR: valor invalido ingresado");
            }

            maximo(num1,num2);
            break;
        default:
            Console.WriteLine("ERROR: valor no esperado");
            break;
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

double valorAbs (double num)
{
    num = Math.Sqrt((num * num));
    return num;
}

double cuadrado (double num)
{
    num = num * num;
    return num;
}

double raizCuadrada (double num)
{
    if (num >= 0)
    {
        num = Math.Sqrt(num);    
    }
    else
    {
        Console.WriteLine("Raiz no existente en el conjunto de los numeros Reales");
        num = 0;
    }
    
    return num;
}

double seno (double num)
{
    double radianes = num * (Math.PI / 180.0);
    num = Math.Sin(radianes); 
    return num;
}

double coseno (double num)
{
    double radianes = num * (Math.PI / 180.0);
    num = Math.Cos(radianes); 
    return num;
}

void maximo (double num1, double num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("El numero " + num1 + " es el mayor, y el numero " + num2 + " es el menor");
    }
    else
    {
        Console.WriteLine("El numero " + num2 + " es el mayor, y el numero " + num1 + " es el menor");
    }
}