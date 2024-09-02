namespace RepartidoCirculo;

public class Circulo
{
    private double radio;

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public Circulo(double radio)
    {
        this.Radio = radio;
    }

    public void GetArea()
    {
        double a = Math.PI;
        Console.WriteLine(this.Radio * this.Radio * a);
    }

    public void GetPerimetro()
    {
        double a = Math.PI;
        Console.WriteLine(2 * a * this.Radio); 
    }
}