//for(int i=1; i<=20; i++)
//{
//    //if(i == 5)
//    //{
//    //    Console.WriteLine("Eres el número 5");
//    //    break;
//    //}

//    if ((i % 5) == 0)
//    {
//        Console.WriteLine("Eres el multiplo de 5");
//        continue;
//    }

//    Console.WriteLine(i.ToString());
//}

using System.Runtime.CompilerServices;

int contador = 1;

//while(contador <= 20)
//{
//    if ((contador % 5) == 0)
//    {
//        Console.WriteLine("Eres el multiplo de 5");
//        contador++;
//        break;
//    }

//    Console.WriteLine(contador.ToString());
//    contador++;
//}

//do
//{
//    if ((contador % 5) == 0)
//    {
//        Console.WriteLine("Eres el multiplo de 5");
//        contador++;
//        break;
//    }

//    Console.WriteLine(contador.ToString());
//    contador++;
//} while (contador <= 20);


string opcion = string.Empty;

//while (opcion != "3")
//{
//    Console.WriteLine("Menu de Opciones");
//    Console.WriteLine("1. Imprimir mi nombre");
//    Console.WriteLine("2. Imprimir mi apellido");
//    Console.WriteLine("3. Salir del sistema");
//    opcion = Console.ReadLine();


//    switch (opcion)
//    {
//        case "1": 
//            Console.WriteLine("Samuel");
//            break;

//        case "2":
//            Console.WriteLine("Arellano");
//            break;

//        case "3":
//            Console.WriteLine("Gracias por usar el sistema");
//            break;

//        default:
//            Console.WriteLine("Esta opción no existe");
//            break;
//    }
//}

do
{
    Console.WriteLine("Menu de Opciones");
    Console.WriteLine("1. Imprimir mi nombre");
    Console.WriteLine("2. Imprimir mi apellido");
    Console.WriteLine("3. Salir del sistema");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Samuel");
            break;

        case "2":
            Console.WriteLine("Arellano");
            break;

        case "3":
            Console.WriteLine("Gracias por usar el sistema");
            break;

        default:
            Console.WriteLine("Esta opción no existe");
            break;
    }
} while (opcion != "3");


Console.ReadLine();