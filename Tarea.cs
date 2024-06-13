namespace EspacioTarea;

class Tarea
{
    private int tareaId=0;

    private string descripcion;

    private int duracion;
    public Tarea()
    {
    
    }
    public Tarea(int tareaId, string descripcion, int duracion)
    {
        this.TareaId = tareaId;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
    }

    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int TareaId { get => tareaId; set => tareaId = value; }
    public int Duracion { get => duracion; set => duracion = value; }
}
