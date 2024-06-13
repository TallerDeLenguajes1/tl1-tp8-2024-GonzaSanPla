
namespace EspacioCalculadora;

class Calculadora
{
    private double dato=0;

    List<Operacion> operaciones= new List<Operacion>();

    public List<Operacion> Operaciones { get => operaciones; set => operaciones = value; }

    public void Sumar(double termino)
    {
        Operacion resultOp= new Operacion();
        resultOp.ResultadoAnterior=dato;

        dato=dato+termino;
        
        resultOp.NuevoValor=dato;
        resultOp.UltOperacion=TipoOperacion.Suma;
        Operaciones.Add(resultOp);
    }
    public void Restar(double termino)
    {
        
        Operacion resultOp= new Operacion();
        resultOp.ResultadoAnterior=dato;

        dato=dato-termino;
        
        resultOp.NuevoValor=dato;
        resultOp.UltOperacion=TipoOperacion.Resta;
        Operaciones.Add(resultOp);

    }
    public void Multiplicar(double termino)
    {
        
        Operacion resultOp= new Operacion();
        resultOp.ResultadoAnterior=dato;

        dato=dato*termino;
        
        resultOp.NuevoValor=dato;
        resultOp.UltOperacion=TipoOperacion.Multiplicacion;
        Operaciones.Add(resultOp);
    }
    public void Dividir(double termino)
    {
        
        Operacion resultOp= new Operacion();
        resultOp.ResultadoAnterior=dato;

        dato=dato/termino;
        
        resultOp.NuevoValor=dato;
        resultOp.UltOperacion=TipoOperacion.Division;
        Operaciones.Add(resultOp);
    }
    public void Limpiar()
    {
        
        Operacion resultOp= new Operacion();
        resultOp.ResultadoAnterior=dato;

        dato=0;
        
        resultOp.NuevoValor=dato;
        resultOp.UltOperacion=TipoOperacion.Limpiar;
        Operaciones.Add(resultOp);
    }

    public double Resultado()
    {
        return dato;
    }

    
}


public enum TipoOperacion
{
    Suma,
    Resta,
    Division,
    Multiplicacion,
    Limpiar
}

public class Operacion
{
    private double resultadoAnterior;

    private double nuevoValor;

    private TipoOperacion ultOperacion;

    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
    public TipoOperacion UltOperacion { get => ultOperacion; set => ultOperacion = value; }

    public void MostrarOperacion()
    {
        Console.WriteLine("\nResultado anterior:"+ResultadoAnterior+"\nNuevo valor:"+NuevoValor+"\nTipo de opreacion:"+ultOperacion);
    }
}

