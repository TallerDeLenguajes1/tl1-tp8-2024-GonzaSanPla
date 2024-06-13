// See https://aka.ms/new-console-template for more information
using EspacioTarea;
using EspacioCalculadora;


//----- Ejericio 1 -----

// Random rand=new Random();
// int numTareas=rand.Next(5,20);
// string? opcion="";
// string? idMoverS;
// string? buscar="";
// int idMover;
// Tarea tareaMover= new Tarea();

// List<Tarea> pendiente= new List<Tarea>();
// List<Tarea> realizado= new List<Tarea>();

// pendiente = crearTareas( numTareas);

// while(opcion!="0")
// {
//     Console.WriteLine("\nElija una opcion:\n1-Mostrar listado de tareas pendientes y realizadas\n2-Mover tarea de pendiente a realizada\n3-Buscar tarea por descripcion una tarea pendiente\n0-Salir");
//     opcion=Console.ReadLine();

//     switch(opcion)
//     {
//         case "1":
//             Console.WriteLine("\n Pendiente:");
//             mostrarTareas(pendiente);
//             Console.WriteLine("\n Realizado");
//             mostrarTareas(realizado);
//             break;
//         case "2":
//             do
//             {
//                 mostrarTareas(pendiente);
//                 Console.WriteLine("\nIngrese el id de la tarea que desea mover:");
//                 idMoverS=Console.ReadLine();
//             } while (!int.TryParse(idMoverS, out idMover));


//             foreach (var tarea in pendiente)
//             {
//                 if(tarea.TareaId==idMover)
//                 {
//                     tareaMover=tarea;
//                 }
//             }

//             realizado.Add(tareaMover);
//             pendiente.Remove(tareaMover);
//             break;
//         case "3":

//             Console.WriteLine("\nIngrese la descripcion de la tarea que desea buscar:");
//             buscar=Console.ReadLine();

//             foreach (var tarea in pendiente)
//             {
//                 if(tarea.Descripcion.Contains(buscar))
//                 {
//                     mostrarTarea(tarea);
//                 }
//             }
//         break;
//     }

// }

// static List<Tarea> crearTareas(int numTareas)
// {
//     Random rand=new Random();
//     List<Tarea> tareas= new List<Tarea>();
//     int duracion;

//     for (int i = 0; i < numTareas; i++)
//     {
//         duracion = rand.Next(10, 100);
//         Tarea nuevaTarea = new Tarea(i, "Soy la tarea " + i, duracion);
//         tareas.Add(nuevaTarea);
//     }

//     return tareas;
// }
// static void mostrarTarea( Tarea tarea)
// {
//     Console.WriteLine("\nId:"+tarea.TareaId+"||Descripcion:"+tarea.Descripcion+"||Duracion:"+tarea.Duracion);
// }

// static void mostrarTareas(List<Tarea> tareas)
// {
//     if(tareas!= null)
//     {
//         foreach (var tarea in tareas)
//         {
//             mostrarTarea(tarea);
//         }
//     }else
//     {
//         Console.WriteLine("\nNo hay tareas en esta lista");
//     }

// }

//----- Ejericio 2 -----


string? eleccion = "10";  //El ? es para decir que es nulleable 
string? numS = "";
double num = 0;


Calculadora calc = new Calculadora();

while (eleccion != "0")
{
    while (eleccion != "0" && eleccion != "1" && eleccion != "2" && eleccion != "3" && eleccion != "4" && eleccion != "5")
    {
        Console.WriteLine("\nElija que operacion desea realizar:\n1-Sumar \n2-Restar \n3-Multiplicar \n4-Dividir\n5-Refresacar\n0-Salir");
        eleccion = Console.ReadLine();
        if (eleccion != "0" && eleccion != "5")
        {
            Console.WriteLine("\nIngrese el numero para operar:");
            numS = Console.ReadLine();
        }
    }

    if (double.TryParse(numS, out num))
    {
        switch (eleccion)
        {
            case "1":
                calc.Sumar(num);
                break;

            case "2":
                calc.Restar(num);
                break;

            case "3":
                calc.Multiplicar(num);
                break;

            case "4":
                if (num != 0)
                {
                    calc.Dividir(num);
                }
                else
                {
                    Console.WriteLine("No se puede divir en 0");
                }

                break;

            case "5":
                calc.Limpiar();
                break;
        }

        Console.WriteLine("\nEl resultado es:" + calc.Resultado());
    }
    if (eleccion != "0")
    {
        eleccion = "A";
    }
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("\nHistorial de operaciones:");
foreach(Operacion ope in calc.Operaciones)
{
    ope.MostrarOperacion()
;}
