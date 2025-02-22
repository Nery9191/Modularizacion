using System;
using System.Diagnostics.CodeAnalysis;
using System.Timers;

static void calculadora()
{
    Console.WriteLine("Ingrese el primer numero ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero ");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la operacion a realizar +, *, /, o - ");
    string operacion = Console.ReadLine();
    int resultado = 0;
    switch (operacion)
    {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
        case "/":
            resultado = num1 / num2;
            break;
        default:
            Console.WriteLine("Operacion no valida");
            break;
    }
    Console.WriteLine("El resultado es: " + resultado);
}

static void validacionusuarioycontraseña()
{
    Console.WriteLine("Ingrese el usuario, por defecto ''admin''");
    string usuario = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña, por defecto ''1234''");
    string contraseña = Console.ReadLine();
    while (true)
    {
        if (usuario == "admin" && contraseña == "1234")
        {
            Console.WriteLine("Bienvenido");
            break;
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos");
            break;
        }
    }
}

static void numeroprimo()
{
    Console.WriteLine("Ingrese un numero");
    int num = int.Parse(Console.ReadLine());
    int contador = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        Console.WriteLine("El numero es primo");
    }
    else
    {
        Console.WriteLine("El numero no es primo");
    }
}

static void sumdenumerospares()
{
    int num;
    do
    {
        Console.WriteLine("Ingrese un número (0 para salir):");
        num = int.Parse(Console.ReadLine());
        int suma = 0;

        for (int i = 0; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
        }

        if (num != 0)
        {
            Console.WriteLine("La suma de los números pares es: " + suma);
        }

    } while (num != 0);
}

static void connversiontemperaturac()
{
    Console.WriteLine("Ingrese la temperatura en grados Celsius");
    double celsius = double.Parse(Console.ReadLine());
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
}
static void conversiontemperaturaf()
{
    Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
    double fahrenheit = double.Parse(Console.ReadLine());
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine("La temperatura en grados Celsius es: " + celsius);
}

static void contadorvocales()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine().ToLower();
Console.ReadLine();
    int contador = 0;
    for (int i = 0; i < palabra.Length; i++)
    {
        if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
        {
            contador++;
        }
    }
    Console.WriteLine("La cantidad de vocales es: " + contador);
}
static void calculodefactorial()
{
    Console.WriteLine("Ingrese un numero");
    int num = int.Parse(Console.ReadLine());
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("El factorial de " + num + " es: " + factorial);
}

static void adivinanza()
{
    Random random = new Random();
    int numeroaleatorio = random.Next(1, 100);
    int intentos = 0;
    int numero;
    do
    {
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
        if (numero > numeroaleatorio)
        {
            Console.WriteLine("El numero es menor");
        }
        else if (numero < numeroaleatorio)
        {
            Console.WriteLine("El numero es mayor");
        }
        intentos++;
    } while (numero != numeroaleatorio);
    Console.WriteLine("Felicidades, adivinaste el numero en " + intentos + " intentos");
}

Console.WriteLine("Ingrese el numero de la funcion a ejecutar");
Console.WriteLine("1 = Calculadora, 2 = validacioncontraseña, 3 = comprobar numero primo ");
Console.WriteLine("4 = Suma de numeros pares 5 = convertir Celcius a Farenheit, 6 = Convertir Farenheit a Celcius ");
Console.WriteLine(" 7 = Contador de vocales, 8 = Calcular Factorial, 9 = Adivina el numero");
string funcion = Console.ReadLine();
switch (funcion)
{
    case "1":
        calculadora();
        break;
    case "2":
        validacionusuarioycontraseña();
        break;
    case "3":
        numeroprimo();
        break;
    case "4":
        sumdenumerospares();
        break;
    case "5":
        conversiontemperaturaf();
        break;
    case "6":
        conversiontemperaturaf();
        break;
    case "7":
        contadorvocales();
        break;
    case "8":
        calculodefactorial();
        break;
    case "9":
        adivinanza();
        break;
    default:
        Console.WriteLine("Funcion no valida");
        break;
}
