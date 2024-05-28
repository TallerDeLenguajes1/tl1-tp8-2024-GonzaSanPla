// See https://aka.ms/new-console-template for more information
using EspacioTarea;

//----- Ejericio 1 -----

Random rand=new Random();
int numTareas=rand.Next(5,20);
string? opcion="";
string? idMover;
Tarea tareaMover= new Tarea();

List<Tarea> pendiente= new List<Tarea>();
List<Tarea> realizado= new List<Tarea>();

pendiente = crearTareas( numTareas);

while(opcion!="0")
{
    Console.WriteLine("\nElija una opcion:\n1-Mostrar listado de tareas pendientes y realizadas\n2-Mover tarea de pendiente a realizada\n3-Buscar tarea por descripcion una tarea pendiente\n0-Salir");
    opcion=Console.ReadLine();

    switch(opcion)
    {
        case "1":
            Console.WriteLine("\n Pendiente:");
            mostrarTareas(pendiente);
            Console.WriteLine("\n Realizado");
            mostrarTareas(realizado);
            break;
        case "2":
            mostrarTareas(pendiente);
            Console.WriteLine("\nIngrese el id de la tarea que desea mover:");
            idMover=Console.ReadLine();

            foreach (var tarea in pendiente)
            {
                if(tarea.TareaId==idMover)
                {
                    tareaMover=tarea;
                }
            }

            realizado.Add(tareaMover);
            pendiente.Remove(tareaMover);
            break;
    }

}

static List<Tarea> crearTareas(int numTareas)
{
    Random rand=new Random();
    List<Tarea> tareas= new List<Tarea>();
    int duracion;

    for (int i = 0; i < numTareas; i++)
    {
        duracion = rand.Next(10, 100);
        Tarea nuevaTarea = new Tarea(i, "Soy la tarea " + i, duracion);
        tareas.Add(nuevaTarea);
    }

    return tareas;
}
static void mostrarTarea( Tarea tarea)
{
    Console.WriteLine("\nId:"+tarea.TareaId+"||Descripcion:"+tarea.Descripcion+"||Duracion:"+tarea.Duracion);
}

static void mostrarTareas(List<Tarea> tareas)
{
    if(tareas!= null)
    {
        foreach (var tarea in tareas)
        {
            mostrarTarea(tarea);
        }
    }else
    {
        Console.WriteLine("\nNo hay tareas en esta lista");
    }
    
}
