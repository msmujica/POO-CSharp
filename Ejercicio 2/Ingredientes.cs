namespace RepartidoCirculo.Ejercicio_2;

public class Ingredientes
{

    private string nombre;
    private int precio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Ingredientes(string name, int price)
    {
        this.Nombre = name;
        this.Precio = price;
    }
}